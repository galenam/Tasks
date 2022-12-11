using System.Text;

namespace Tasks.AppCode;
/*
 * Узнав, что ДНК не является случайной строкой, только что поступившие в Институт биоинформатики студенты группы информатиков
предложили использовать алгоритм сжатия, который сжимает повторяющиеся символы в строке.

Кодирование осуществляется следующим образом:
$ = 'ааааббсаа' преобразуется в 'а462с1а2 ', то есть группы одинаковых символов исходной строки заменяются на этот символ
и количество его повторений в этой позиции строки.

Напишите программу, которая считывает строку, кодирует её предложенным алгоритмом и выводит закодированную
последовательность на стандартный вывод. Кодирование должно учитывать регистр символов.
Sample input 1:
aaaabbcaa

Sample output 1:
а4b2с1а2

Sample input 2:
аbс

Sample output 2:
а1b1с1
 * 
 */
public static  class DNACoding
{
    public static string Coding(string source)
    {
        if (string.IsNullOrEmpty(source))
        {
            return string.Empty;
        }

        if (source.Length == 1)
        {
            return $"{source}1";
        }

        var sb = new StringBuilder();
        var previousCh = source[0];
        var count = 1L;
        for(var i = 1; i < source.Length; i++)
        {
            if (source[i] != previousCh)
            {
                sb.Append($"{previousCh}{count}");
                count = 1;
                previousCh = source[i];
            }
            else
            {
                count++;
            }
        }
        sb.Append($"{previousCh}{count}");

        return sb.ToString();
    }
}