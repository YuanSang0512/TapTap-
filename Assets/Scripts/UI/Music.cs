using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music
{
        private static Music instance;

    private Music()
    {
        MusicValue = 50f; 
    }

    public static Music Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Music();
                }
                return instance;
            }
        }

        // һ���������ԣ����Դ��ⲿ���ʺ��޸�
        public float MusicValue { get; set; }

}


