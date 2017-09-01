﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Founders
{
    class MindStorage
    {
        MindStorage()
        {

        }

        string [] generateNewPan(string user, string pass, string email)
        {
            string[] newpan = new string[25];
            byte[] phrase2bytes = Encoding.Default.GetBytes(user.ToLower() + pass);
            byte[] phrase1bytes = Encoding.Default.GetBytes(email);
            var phrase1 = BitConverter.ToString(phrase1bytes).Replace("-", "");
            var phrase2 = BitConverter.ToString(phrase2bytes).Replace("-", "");
            int size = 0;
            if (phrase1.Length >= phrase2.Length)
                size = phrase1.Length;
            else
                size = phrase2.Length;
            var combPhrase = "";

            for(int i = 0; i < size; i++)
            {
                if (i < phrase1.Length)
                    combPhrase += phrase1[i];
                if (i < phrase2.Length)
                    combPhrase += phrase2[i];
            }
            string fullAn = "";
            for (int k = 0; k < 800 / combPhrase.Length; k++)
                fullAn += combPhrase;
            fullAn = fullAn.Substring(0, 800);
            for (int l = 0; l < 25; l++)
                newpan[l] = fullAn.Substring(l * 32, 32);

            return newpan;
        }
    }
}
