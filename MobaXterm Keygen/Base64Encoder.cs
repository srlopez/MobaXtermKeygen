using System;
using System.Collections.Generic;
using System.Linq;

namespace MobaXterm_Keygen
{
    public class Base64Encoder
    {
        private static readonly IReadOnlyList<char> alphabet = new List<char> {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H',
            'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
            'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X',
            'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
            'w', 'x', 'y', 'z', '0', '1', '2', '3',
            '4', '5', '6', '7', '8', '9', '+', '/',
            '='
        };
        public static string Encode(byte[] bytes) {
            var byteGroupCount = bytes.Length / 3;
            var encodedBytes = "";

            for (var i = 0; i < byteGroupCount; i++) {
                var codingKey = bytes.Skip(3 * i).Take(3).ToArray();
                var codingInt = (int)ConvertLittleEndian(codingKey);

                encodedBytes += alphabet[codingInt & 0x3f];
                encodedBytes += alphabet[(codingInt >> 6) & 0x3f];
                encodedBytes += alphabet[(codingInt >> 12) & 0x3f];
                encodedBytes += alphabet[(codingInt >> 18) & 0x3f];
            }
            return encodedBytes;
        }
        private static ulong ConvertLittleEndian(byte[] array)
        {
            var pos = 0;
            ulong result = 0;
            foreach (var by in array) {
                result |= (ulong)by << pos;
                pos += 8;
            }
            return result;
        }
    }
}