# CharToROM
A project aimed at making programming Terraria XOR based ROM easy as 123.

This project was aimed at making the programming of a ROM designed by @yfdyzjt much easier. Below is the process of how to manually decode the inputs based on 15 values. 

![image](https://github.com/RussDev7/CharToROM/assets/33048298/88686ad0-7c33-468b-96f3-5db51f3eb039)

This uses a truth table that follows the XOR format as seen below.

![TruthTable](https://github.com/RussDev7/CharToROM/assets/33048298/29b1057f-78a9-4206-87c7-d0a00e7cbb84)

So with this information, we can then manually decode the pixels needed to be translated to XOR ROM.

![image (1)](https://github.com/RussDev7/CharToROM/assets/33048298/f0bf43c0-7a05-487f-951a-63fbb00780dd)

However doing this is very time consuming and prone to human error. So I created a tool that can automate this for *super* easy programming of your ROM. It's very friendly user interface will allow you to build any character you want and convert it into your ROM's data format. Even easer is that the export feature allows you to store each value quickly to a file where an in-game command `/rom (schematic name)` can be used to paste the wiring into the game as demonstrated in this gif.

![RomDemo1](https://github.com/RussDev7/CharToROM/assets/33048298/933c2f74-5fda-4d7f-a56f-d344b3a9340a)

From here a quick copy and paste of the wires into the ROM using TEdit will allow ready to use storage. Below I will be providing the code needed to upload the ROM data in-game using commands.

Entree point:
`Terraria.Chat > ChatCommandProcessor (OR CreateOutgoingMessage)`

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria.Chat.Commands;
using Terraria.Localization;

namespace Terraria.Chat
{
    public partial class ChatCommandProcessor : IChatProcessor
    {
        public void ProcessIncomingMessage(ChatMessage message, int clientId)
        {
            if (message.Text.Contains("/rom"))
            {
                string SchemName = "";
                int RunBy = 0;
                string Message = message.Text;
                Vector2 playerPosition = Main.LocalPlayer.position / 16;
                Vector2 wirePosition = Main.LocalPlayer.position / 16;
                int WireColor = 1; // Change to 2 if you want the first frame to be empty.

                try
                {
                    // Create a new list of words based on a sentences spaces.
                    List<string> wordList = Message.TrimStart(new char[]{' '}).Split(new char[]{' '}).ToList<string>();
                    wordList.RemoveAt(0); // Remove the first word -> /schem.
                    
                    // Define variables based on the list of words.
                    foreach (string OutString in string.Join(" ", wordList.ToArray()).Split(new char[]{' '}))
                    {
                        if (RunBy == 0) // Define the first variable.
                        {
                            SchemName = OutString;
                            RunBy++;
                        }
                    }

                    // Load Schem
                    if (SchemName == "")
                    {
                        Console.WriteLine("ERROR: Type a schematic name!");
                        Main.NewTextMultiline("ERROR: Type a schematic name!", false, Color.Red, -1);
                    }
                    else
                    {
                        try
                        {
                            foreach (string OutString in File.ReadLines(@"C:\Program Files (x86)\Steam\steamapps\common\Terraria\#romupload\" + SchemName + ".txt"))
                            {
                                // Remove all spaces in each line, Get Each Char In Each Line.
                                foreach (char c in OutString.Replace(" ", ""))
                                {
                                    // Check if value is 0 or 1.
                                    if (int.Parse(c.ToString()) == 1)
                                    {
                                        // Get the wire color.
                                        if (WireColor == 1)
                                        {
                                            // Place wire.
                                            WorldGen.PlaceWire((int)wirePosition.X, (int)wirePosition.Y);

                                            // Paint all for visual.
                                            Main.tile[(int)wirePosition.X, (int)wirePosition.Y].wallColor(25);
                                        }
                                        else if (WireColor == 2)
                                        {
                                            // Place wire.
                                            WorldGen.PlaceWire2((int)wirePosition.X, (int)wirePosition.Y);

                                            // Paint all for visual.
                                            Main.tile[(int)wirePosition.X, (int)wirePosition.Y].wallColor(25);
                                        }
                                        else if (WireColor == 3)
                                        {
                                            // Place wire.
                                            WorldGen.PlaceWire3((int)wirePosition.X, (int)wirePosition.Y);

                                            // Paint all for visual.
                                            Main.tile[(int)wirePosition.X, (int)wirePosition.Y].wallColor(25);
                                        }
                                        else if (WireColor == 4)
                                        {
                                            // Place wire.
                                            WorldGen.PlaceWire4((int)wirePosition.X, (int)wirePosition.Y);

                                            // Paint all for visual.
                                            Main.tile[(int)wirePosition.X, (int)wirePosition.Y].wallColor(25);
                                        }
                                    }

                                    // Progress position left.
                                    wirePosition.X += 1;
                                }

                                // Reset horizontal postion.
                                wirePosition.X = playerPosition.X;

                                // Progress wire color.
                                if (WireColor == 4)
                                {
                                    // Reset wirecolor back to 1.
                                    WireColor = 1;

                                    // Progress position down.
                                    wirePosition.Y += 3;
                                }
                                else
                                {
                                    WireColor++;
                                }
                            }

                            // Display Console
                            Console.WriteLine(string.Concat(new string[]{"Schematic: ", SchemName.ToString(), " has loaded successfully!"}));
                            Main.NewTextMultiline(string.Concat(new string[]{"Schematic: ", SchemName.ToString(), " has loaded successfully!"}), false, Color.Green, -1);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Schematic: " + SchemName.ToString() + " was not found!");
                            Main.NewTextMultiline("Schematic: " + SchemName.ToString() + " was not found!", false, Color.Red, -1);
                        }
                    }

                    // Command Finished
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Command Usage - /rom [schem]");
                    Main.NewTextMultiline("ERROR: Command Usage - /rom [schem]", false, Color.Red, -1);
                }

                return;
            }

            IChatCommand chatCommand;
            if (this._commands.TryGetValue(message.CommandId, out chatCommand))
            {
                chatCommand.ProcessIncomingMessage(message.Text, (byte)clientId);
                message.Consume();
                return;
            }
            if (this._defaultCommand != null)
            {
                this._defaultCommand.ProcessIncomingMessage(message.Text, (byte)clientId);
                message.Consume();
            }
        }
    }
}
```

