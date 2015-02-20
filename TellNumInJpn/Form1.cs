// TellNumInJpn v1.10
// Written by Raymai97 on 19 Feb 2015 (CNY2015)
// Email: cheeboonray@gmail.com

// Added "Space Separation" option
// Fixed bugs such as Kanji "点" appeared in Hiragana, didn't show ltsu (っ) romaji

// toKanji and toHiragana split the number into parts (that are <= 9999) and pass them to _toXXX
// _toKanji and _toHiragana process number <= 9999, and pass a digit at a time to __toXXX
// __toKanji and __toHiragana process the most simplest unit of number aka a digit (0~9)
// The methods above are limited to process "number" only.

// toRomaji is different, it can process most of the common Hiragana to Romaji
// It took me pretty much of effort to figure out a good enough algorithm for it...
// I hope my method is not bad btw...

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TellNumInJpn
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            // Generate a simple database for hiragana/romaji recognization
            foreach (string data in Properties.Resources.romajihira.Split(';'))
            {
                int i = data.IndexOf(",");
                if (i < 0) continue;
                JpnChars.Add(new JpnChar() { romaji = data.Substring(0, i) , hiragana = data.Substring(i+1) });
            }
        }

        string msgNumOnly = "Please enter number only!";
        string msgMindBlown = "MINDBLOWN! Please try a smaller value / lesser decimal places.";
        string msgNoNeg = "Negative value is not supported!";
        bool SpaceHiraRomaji = true;
        List<JpnChar> JpnChars = new List<JpnChar>();

        string RomajiOfHira(string hiragana)
        {
            string romaji = "";
            foreach (JpnChar c in JpnChars)
            {
                if (c.hiragana == hiragana) { romaji = c.romaji; break; }
            }
            return romaji;
        }

        string toRomaji(string hiragana)
        {
            string Romaji = "";
            string romaji = "", hira = "";
            bool ltsu = false;
            for (int i = 0; i <= hiragana.Length - 1; i++)
            {
                hira = hiragana.Substring(i, 1);
                romaji = RomajiOfHira(hira);
                if (i + 1 <= hiragana.Length - 1)
                {
                    char next = hiragana[i+1];
                    switch (hira)
                    {
                        case "き":
                            switch (next)
                            {
                                case 'ゃ': romaji = "kya"; break;
                                case 'ゅ': romaji = "kyu"; break;
                                case 'ょ': romaji = "kyo"; break;
                            }
                            break;
                        case "ぎ":
                            switch (next)
                            {
                                case 'ゃ': romaji = "gya"; break;
                                case 'ゅ': romaji = "gyu"; break;
                                case 'ょ': romaji = "gyo"; break;
                            }
                            break;
                        case "し":
                            switch (next)
                            {
                                case 'ゃ': romaji = "sha"; break;
                                case 'ゅ': romaji = "shu"; break;
                                case 'ょ': romaji = "sho"; break;
                            }
                            break;
                        case "じ":
                            switch (next)
                            {
                                case 'ゃ': romaji = "ja"; break;
                                case 'ゅ': romaji = "ju"; break;
                                case 'ょ': romaji = "jo"; break;
                            }
                            break;
                        case "ち":
                            switch (next)
                            {
                                case 'ゃ': romaji = "cha"; break;
                                case 'ゅ': romaji = "chu"; break;
                                case 'ょ': romaji = "cho"; break;
                            }
                            break;
                        case "に":
                            switch (next)
                            {
                                case 'ゃ': romaji = "nya"; break;
                                case 'ゅ': romaji = "nyu"; break;
                                case 'ょ': romaji = "nyo"; break;
                            }
                            break;
                        case "ひ":
                            switch (next)
                            {
                                case 'ゃ': romaji = "hya"; break;
                                case 'ゅ': romaji = "hyu"; break;
                                case 'ょ': romaji = "hyo"; break;
                            }
                            break;
                        case "び":
                            switch (next)
                            {
                                case 'ゃ': romaji = "bya"; break;
                                case 'ゅ': romaji = "byu"; break;
                                case 'ょ': romaji = "byo"; break;
                            }
                            break;
                        case "ぴ":
                            switch (next)
                            {
                                case 'ゃ': romaji = "pya"; break;
                                case 'ゅ': romaji = "pyu"; break;
                                case 'ょ': romaji = "pyo"; break;
                            }
                            break;
                        case "み":
                            switch (next)
                            {
                                case 'ゃ': romaji = "mya"; break;
                                case 'ゅ': romaji = "myu"; break;
                                case 'ょ': romaji = "myo"; break;
                            }
                            break;
                        case "り":
                            switch (next)
                            {
                                case 'ゃ': romaji = "rya"; break;
                                case 'ゅ': romaji = "ryu"; break;
                                case 'ょ': romaji = "ryo"; break;
                            }
                            break;
                        case "っ":
                            ltsu = true;
                            continue;
                        case " ":
                            romaji = " "; 
                            break;
                    }
                    if (ltsu) { romaji = romaji[0] + romaji; ltsu = false; }
                }
                Romaji += romaji ;
            }
            return Romaji;
        }

        string __toKanji(string s, int digit)
        {
            switch (digit)
            {
                case 3:
                    switch (s)
                    {
                        case "9": return "九千";
                        case "8": return "八千";
                        case "7": return "七千";
                        case "6": return "六千";
                        case "5": return "五千";
                        case "4": return "四千";
                        case "3": return "三千";
                        case "2": return "二千";
                        case "1": return "千";
                        case "0": return "";
                    }
                    break;
                case 2:
                    switch (s)
                    {
                        case "9": return "九百";
                        case "8": return "八百";
                        case "7": return "七百";
                        case "6": return "六百";
                        case "5": return "五百";
                        case "4": return "四百";
                        case "3": return "三百";
                        case "2": return "二百";
                        case "1": return "百";
                        case "0": return "";
                    }
                    break;
                case 1:
                    switch (s)
                    {
                        case "9": return "九十";
                        case "8": return "八十";
                        case "7": return "七十";
                        case "6": return "六十";
                        case "5": return "五十";
                        case "4": return "四十";
                        case "3": return "三十";
                        case "2": return "二十";
                        case "1": return "十";
                        case "0": return "";
                    }
                    break;
                case 0:
                    switch (s)
                    {
                        case "9": return "九";
                        case "8": return "八";
                        case "7": return "七";
                        case "6": return "六";
                        case "5": return "五";
                        case "4": return "四";
                        case "3": return "三";
                        case "2": return "二";
                        case "1": return "一";
                        case "0": return "";
                    }
                    break;
                case -1:
                    switch (s)
                    {
                        case "9": return "九";
                        case "8": return "八";
                        case "7": return "七";
                        case "6": return "六";
                        case "5": return "五";
                        case "4": return "四";
                        case "3": return "三";
                        case "2": return "二";
                        case "1": return "一";
                        case "0": return "零";
                    }
                    break;
            }
            return "?";
        }

        string _toKanji(decimal num)
        {
            string s = num.ToString();
            string Kanji = "", a, b;
            if (s.Contains("."))
            {
                a = s.Substring(0, s.IndexOf("."));
                b = s.Substring(s.IndexOf(".")+1);
            }
            else
            {
                a = s;
                b = "";
            }
            int digit;
            for (digit = a.Length - 1; digit >= 0; digit--)
            {
                Kanji = Kanji + __toKanji(a.Substring(a.Length - 1 - digit, 1), digit);
            }
            if (b.Length > 0)
            {
                Kanji += "点";
                for (digit = b.Length - 1; digit >= 0; digit--)
                {
                    Kanji = Kanji + __toKanji(b.Substring(b.Length - 1 - digit, 1), -1);
                }
            }
            return Kanji;
        }

        string toKanji(decimal num)
        {
            string Kanji = "";
            int debt = 1;
            decimal tmpnum = num;
            while (tmpnum > 9999)
            {
                debt += 1;
                tmpnum = tmpnum / 10000;
            }
            tmpnum = num;
            while (debt > 0)
            {
                if (debt > 1)
                {
                    tmpnum = Math.Truncate(tmpnum / (decimal)Math.Pow(10000, debt - 1)); 
                    Kanji += _toKanji(tmpnum);
                    num -= (tmpnum * (decimal)Math.Pow(10000, debt - 1));
                    tmpnum = num;
                    switch (debt)
                    {
                        case 2: Kanji += "万"; break;
                        case 3: Kanji += "億"; break;
                        case 4: Kanji += "兆"; break;
                    }
                    debt -= 1;
                }
                else
                {
                    Kanji += _toKanji(num);
                    debt -= 1;
                }
            }
            return Kanji;
        }

        string __toHiragana(string s, int digit)
        {
            string hira = "?";
            switch (digit)
            {
                case 3:
                    switch (s)
                    {
                        case "9": hira = "きゅうせん"; break;
                        case "8": hira = "はっせん"; break;
                        case "7": hira = "ななせん"; break;
                        case "6": hira = "ろくせん"; break;
                        case "5": hira = "ごせん"; break;
                        case "4": hira = "よんせん"; break;
                        case "3": hira = "さんぜん"; break;
                        case "2": hira = "にせん"; break;
                        case "1": hira = "せん"; break;
                        case "0": hira = ""; break;
                    }
                    break;
                case 2:
                    switch (s)
                    {
                        case "9": hira = "きゅうひゃく"; break;
                        case "8": hira = "はっぴゃく"; break;
                        case "7": hira = "ななひゃく"; break;
                        case "6": hira = "ろっぴゃく"; break;
                        case "5": hira = "ごひゃく"; break;
                        case "4": hira = "よんひゃく"; break;
                        case "3": hira = "さんびゃく"; break;
                        case "2": hira = "にひゃく"; break;
                        case "1": hira = "ひゃく"; break;
                        case "0": hira = ""; break;
                    }
                    break;
                case 1:
                    switch (s)
                    {
                        case "9": hira = "きゅうじゅう"; break;
                        case "8": hira = "はちじゅう"; break;
                        case "7": hira = "ななじゅう"; break;
                        case "6": hira = "ろくじゅう"; break;
                        case "5": hira = "ごじゅう"; break;
                        case "4": hira = "よんじゅう"; break;
                        case "3": hira = "さんじゅう"; break;
                        case "2": hira = "にじゅう"; break;
                        case "1": hira = "じゅう"; break;
                        case "0": hira = ""; break;
                    }
                    break;
                case 0:
                    switch (s)
                    {
                        case "9": hira = "きゅう"; break;
                        case "8": hira = "はち"; break;
                        case "7": hira = "なな"; break;
                        case "6": hira = "ろく"; break;
                        case "5": hira = "ご"; break;
                        case "4": hira = "よん"; break;
                        case "3": hira = "さん"; break;
                        case "2": hira = "に"; break;
                        case "1": hira = "いち"; break;
                        case "0": hira = ""; break;
                    }
                    break;
                case -1:
                    switch (s)
                    {
                        case "9": hira = "きゅう"; break;
                        case "8": hira = "はち"; break;
                        case "7": hira = "なな"; break;
                        case "6": hira = "ろく"; break;
                        case "5": hira = "ご"; break;
                        case "4": hira = "よん"; break;
                        case "3": hira = "さん"; break;
                        case "2": hira = "に"; break;
                        case "1": hira = "いち"; break;
                        case "0": hira = "れい"; break;
                    }
                    break;
            }
            if ((hira != "") & SpaceHiraRomaji) { hira += " "; }
            return hira;
        }

        string _toHiragana(decimal num)
        {
            string s = num.ToString();
            string Hiragana = "", a, b;
            if (s.Contains("."))
            {
                a = s.Substring(0, s.IndexOf("."));
                b = s.Substring(s.IndexOf(".") + 1);
            }
            else
            {
                a = s;
                b = "";
            }
            int digit;
            for (digit = a.Length - 1; digit >= 0; digit--)
            {
                Hiragana = Hiragana + __toHiragana(a.Substring(a.Length - 1 - digit, 1), digit);
            }
            if (b.Length > 0)
            {
                Hiragana += "てん";
                if (SpaceHiraRomaji) { Hiragana += " "; }
                for (digit = b.Length - 1; digit >= 0; digit--)
                {
                    Hiragana = Hiragana + __toHiragana(b.Substring(b.Length - 1 - digit, 1), -1);
                }
            }
            return Hiragana;
        }

        string toHiragana(decimal num)
        {
            string Hiragana = "";
            int debt = 1;
            decimal tmpnum = num;
            while (tmpnum > 9999)
            {
                debt += 1;
                tmpnum = tmpnum / 10000;
            }
            tmpnum = num;
            while (debt > 0)
            {
                if (debt > 1)
                {
                    tmpnum = Math.Truncate(tmpnum / (decimal)Math.Pow(10000, debt - 1));
                    Hiragana += _toHiragana(tmpnum);
                    num -= (tmpnum * (decimal)Math.Pow(10000, debt - 1));
                    tmpnum = num;
                    switch (debt)
                    {
                        case 2: Hiragana += "まん"; break;
                        case 3: Hiragana += "おく"; break;
                        case 4: Hiragana += "ちょう"; break;
                    }
                    if (SpaceHiraRomaji) { Hiragana += " "; }
                    debt -= 1;
                }
                else
                {
                    Hiragana += _toHiragana(num);
                    debt -= 1;
                }
            }
            // Lazy way to trim excessive space.
            Hiragana = Hiragana.Trim(); 
            return Hiragana;
        }

        void DoJob()
        {
            string s = txtInput.Text;
            decimal num;
            if (s == "")
            {
                txtHiragana.Clear(); txtKanji.Clear(); txtRomaji.Clear(); return;
            }
            if (decimal.TryParse(s, out num) == false)
            {
                txtHiragana.Text = msgNumOnly; txtKanji.Text = msgNumOnly; txtRomaji.Text = msgNumOnly; return;
            }
            if (s.Contains("-"))
            {
                txtHiragana.Text = msgNoNeg; txtKanji.Text = msgNoNeg; txtRomaji.Text = msgNoNeg; return;
            }
            if ((num >= 9999999999999999 + 1) | (s.Replace(".", "").Length > 28))
            {
                txtHiragana.Text = msgMindBlown; txtKanji.Text = msgMindBlown; txtRomaji.Text = msgMindBlown; return;
            }
            s = num.ToString();
            string Romaji = "", Kanji = "", Hiragana = "";
            Kanji = toKanji(num);
            Hiragana = toHiragana(num);
            Romaji = toRomaji(Hiragana);
            txtHiragana.Text = Hiragana;
            txtRomaji.Text = Romaji;
            txtKanji.Text = Kanji;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            DoJob();
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.somewords,"You found it, cool!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void chkSpaceHiraRomaji_CheckedChanged(object sender, EventArgs e)
        {
            SpaceHiraRomaji = chkSpaceHiraRomaji.Checked;
            DoJob();
        }

    }
}
