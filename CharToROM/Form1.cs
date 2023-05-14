using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CharToArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Main string builder.
        string CharArrayBilder = "000000000000000";

        // Button Color Controls
        #region tiles

        // Change Tile 1
        private void button1_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button1.BackColor == Control.DefaultBackColor)
            {
                button1.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(0, 1).Insert(0, "1");
                UpdateRichTextbox();
            }
            else
            {
                button1.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(0, 1).Insert(0, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 2
        private void button2_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button2.BackColor == Control.DefaultBackColor)
            {
                button2.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(1, 1).Insert(1, "1");
                UpdateRichTextbox();
            }
            else
            {
                button2.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(1, 1).Insert(1, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 3
        private void button3_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button3.BackColor == Control.DefaultBackColor)
            {
                button3.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(2, 1).Insert(2, "1");
                UpdateRichTextbox();
            }
            else
            {
                button3.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(2, 1).Insert(2, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 4
        private void button4_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button4.BackColor == Control.DefaultBackColor)
            {
                button4.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(3, 1).Insert(3, "1");
                UpdateRichTextbox();
            }
            else
            {
                button4.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(3, 1).Insert(3, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 5
        private void button5_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button5.BackColor == Control.DefaultBackColor)
            {
                button5.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(4, 1).Insert(4, "1");
                UpdateRichTextbox();
            }
            else
            {
                button5.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(4, 1).Insert(4, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 6
        private void button6_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button6.BackColor == Control.DefaultBackColor)
            {
                button6.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(5, 1).Insert(5, "1");
                UpdateRichTextbox();
            }
            else
            {
                button6.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(5, 1).Insert(5, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 7
        private void button7_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button7.BackColor == Control.DefaultBackColor)
            {
                button7.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(6, 1).Insert(6, "1");
                UpdateRichTextbox();
            }
            else
            {
                button7.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(6, 1).Insert(6, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 8
        private void button8_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button8.BackColor == Control.DefaultBackColor)
            {
                button8.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(7, 1).Insert(7, "1");
                UpdateRichTextbox();
            }
            else
            {
                button8.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(7, 1).Insert(7, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 9
        private void button9_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button9.BackColor == Control.DefaultBackColor)
            {
                button9.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(8, 1).Insert(8, "1");
                UpdateRichTextbox();
            }
            else
            {
                button9.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(8, 1).Insert(8, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 10
        private void button10_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button10.BackColor == Control.DefaultBackColor)
            {
                button10.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(9, 1).Insert(9, "1");
                UpdateRichTextbox();
            }
            else
            {
                button10.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(9, 1).Insert(9, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 11
        private void button11_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button11.BackColor == Control.DefaultBackColor)
            {
                button11.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(10, 1).Insert(10, "1");
                UpdateRichTextbox();
            }
            else
            {
                button11.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(10, 1).Insert(10, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 12
        private void button12_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button12.BackColor == Control.DefaultBackColor)
            {
                button12.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(11, 1).Insert(11, "1");
                UpdateRichTextbox();
            }
            else
            {
                button12.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(11, 1).Insert(11, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 13
        private void button13_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button13.BackColor == Control.DefaultBackColor)
            {
                button13.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(12, 1).Insert(12, "1");
                UpdateRichTextbox();
            }
            else
            {
                button13.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(12, 1).Insert(12, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 14
        private void button14_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button14.BackColor == Control.DefaultBackColor)
            {
                button14.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(13, 1).Insert(13, "1");
                UpdateRichTextbox();
            }
            else
            {
                button14.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(13, 1).Insert(13, "0");
                UpdateRichTextbox();
            }
        }
        // Change Tile 15
        private void button15_Click(object sender, EventArgs e)
        {
            // Change Color
            if (button15.BackColor == Control.DefaultBackColor)
            {
                button15.BackColor = Color.Lime;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(14, 1).Insert(14, "1");
                UpdateRichTextbox();
            }
            else
            {
                button15.BackColor = Control.DefaultBackColor;

                // Update char.
                CharArrayBilder = CharArrayBilder.Remove(14, 1).Insert(14, "0");
                UpdateRichTextbox();
            }
        }
        #endregion

        // Button Reset
        #region Buttons Reset

        // Reset All Button Colors
        private void button27_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        public void ResetForm()
        {
            button1.BackColor = Control.DefaultBackColor;
            button2.BackColor = Control.DefaultBackColor;
            button3.BackColor = Control.DefaultBackColor;
            button4.BackColor = Control.DefaultBackColor;
            button5.BackColor = Control.DefaultBackColor;
            button6.BackColor = Control.DefaultBackColor;
            button7.BackColor = Control.DefaultBackColor;
            button8.BackColor = Control.DefaultBackColor;
            button9.BackColor = Control.DefaultBackColor;
            button10.BackColor = Control.DefaultBackColor;
            button11.BackColor = Control.DefaultBackColor;
            button12.BackColor = Control.DefaultBackColor;
            button13.BackColor = Control.DefaultBackColor;
            button14.BackColor = Control.DefaultBackColor;
            button15.BackColor = Control.DefaultBackColor;

            // Reset richtextbox.
            richTextBox1.Text = "00000 00000 00000";

            // Reset string builder.
            CharArrayBilder = "000000000000000";
        }
        #endregion

        // Copy Richtextbox
        #region Copy Text

        // Write text to file.
        private void button26_Click(object sender, EventArgs e)
        {
            // Save String To File
            File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Steam\steamapps\common\Terraria\#romupload\" + textBox1.Text + ".txt", richTextBox1.Text.ToString() + Environment.NewLine);

            // Reset form.
            ResetForm();
        }
        #endregion

        // Update the richtextbox.
        public void UpdateRichTextbox()
        {
            // Go through each char within string.
            string finalString = "";
            int previousNumber = 0;
            foreach (char c in CharArrayBilder)
            {
                // Current number within string.
                int currentNumber = int.Parse(c.ToString());

                // Add the current with the previous.
                int mathVar = 0;

                // Compare mathvar to the truth table.
                if (previousNumber == 0 && currentNumber == 0) // 0 + 0 = 0.
                {
                    mathVar = 0;
                }
                else if (previousNumber == 1 && currentNumber == 0) // 1 + 0 = 1 OR 0 + 1 = 1.
                {
                    mathVar = 1;
                }
                else if (previousNumber == 0 && currentNumber == 1)
                {
                    mathVar = 1;
                }
                else if (previousNumber == 1 && currentNumber == 1) // 1 + 1 = 0.
                {
                    mathVar = 0;
                }

                // Add value to final string.
                finalString += mathVar;

                // Update the previous number.
                previousNumber = currentNumber;
            }

            // Update the richtextbox value.
            richTextBox1.Text = String.Join(" ", new String(finalString.Reverse().ToArray()).SplitInParts(5));
        }
    }

    #region Text spacing class
    static class StringExtensions
    {
        public static IEnumerable<String> SplitInParts(this String s, Int32 partLength)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s));
            if (partLength <= 0)
                throw new ArgumentException("Part length has to be positive.", nameof(partLength));

            for (var i = 0; i < s.Length; i += partLength)
                yield return s.Substring(i, Math.Min(partLength, s.Length - i));
        }
    }
    #endregion
}
