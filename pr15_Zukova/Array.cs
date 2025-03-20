using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pr15_Zukova
{
    public class Array
    {
        private int[] _array;

        public Array(int size) 
        {
            if (size <= 0)
            {
                MessageBox.Show("Размер массива должен быть больше нуля. Введите еще раз!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _array = new int[size];
            }
        }

       

    }
}
