#pragma warning disable CS8600
#pragma warning disable CS8604

using System.Resources;
using System.Text;

namespace DeckPasswd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean debug = false;
            ResourceManager resManager = new ResourceManager(typeof(Resource1));
            Console.WriteLine(resManager.GetString("banner"));
            Console.WriteLine(resManager.GetString("info"));
            Console.WriteLine(resManager.GetString("auther"));

            //密码表
            Dictionary<string, string> dic = new Dictionary<string, string>();
            //大写字母
            dic.Add("A", "D");
            dic.Add("B", "E");
            dic.Add("C", "S");
            dic.Add("D", "DE");
            dic.Add("E", "C");
            dic.Add("F", "K");
            dic.Add("G", "CK");
            dic.Add("H", "DES");
            dic.Add("I", "DEC");
            dic.Add("J", "DESD");
            dic.Add("K", "DESDE");
            dic.Add("L", "DESDEK");
            dic.Add("M", "DESDECK");
            dic.Add("N", "DECKDES");
            dic.Add("O", "DDESD");
            dic.Add("P", "CCKSD");
            dic.Add("Q", "KKESD");
            dic.Add("R", "EEESD");
            dic.Add("S", "KKESS");
            dic.Add("T", "DDEDS");
            dic.Add("U", "SSDE");
            dic.Add("V", "SSD");
            dic.Add("W", "CCDE");
            dic.Add("X", "KKSK");
            dic.Add("Y", "SKKKK");
            dic.Add("Z", "SK");
            //数字
            dic.Add("1", "DD");
            dic.Add("2", "EE");
            dic.Add("3", "SS");
            dic.Add("4", "CC");
            dic.Add("5", "KK");
            dic.Add("6", "DDEE");
            dic.Add("7", "DDSS");
            dic.Add("8", "DDCC");
            dic.Add("9", "DDKK");
            dic.Add("0", "EEDD");
            //小写字母
            dic.Add("a", "EEEE");
            dic.Add("b", "EESS");
            dic.Add("c", "EECC");
            dic.Add("d", "ECEC");
            dic.Add("e", "CKCK");
            dic.Add("f", "丁");
            dic.Add("g", "真");
            dic.Add("h", "丁真");
            dic.Add("i", "真丁");
            dic.Add("j", "Egroup");
            dic.Add("k", "锐");
            dic.Add("l", "克");
            dic.Add("m", "五");
            dic.Add("n", "锐克");
            dic.Add("o", "锐克五");
            dic.Add("p", "BFF");
            dic.Add("q", "FFB");
            dic.Add("r", "VVV");
            dic.Add("s", "BF");
            dic.Add("t", "BFV");
            dic.Add("u", "CS");
            dic.Add("v", "CSG");
            dic.Add("w", "CSGO");
            dic.Add("x", "SE");
            dic.Add("y", "SEE");
            dic.Add("z", "SEEASS");
            dic.Add("", "DONE");
            //特殊符号
            dic.Add("/", "牛");
            dic.Add("+", "UwU");
            dic.Add("=", "Not");

            //密码表
            Dictionary<string, string> dic_de = new Dictionary<string, string>();
            //大写字母
            dic_de.Add("D", "A");
            dic_de.Add("E", "B");
            dic_de.Add("S", "C");
            dic_de.Add("DE", "D");
            dic_de.Add("C", "E");
            dic_de.Add("K", "F");
            dic_de.Add("CK", "G");
            dic_de.Add("DES", "H");
            dic_de.Add("DEC", "I");
            dic_de.Add("DESD", "J");
            dic_de.Add("DESDE", "K");
            dic_de.Add("DESDEK", "L");
            dic_de.Add("DESDECK", "M");
            dic_de.Add("DECKDES", "N");
            dic_de.Add("DDESD", "O");
            dic_de.Add("CCKSD", "P");
            dic_de.Add("KKESD", "Q");
            dic_de.Add("EEESD", "R");
            dic_de.Add("KKESS", "S");
            dic_de.Add("DDEDS", "T");
            dic_de.Add("SSDE", "U");
            dic_de.Add("SSD", "V");
            dic_de.Add("CCDE", "W");
            dic_de.Add("KKSK", "X");
            dic_de.Add("SKKKK", "Y");
            dic_de.Add("SK", "Z");
            //数字
            dic_de.Add("DD", "1");
            dic_de.Add("EE", "2");
            dic_de.Add("SS", "3");
            dic_de.Add("CC", "4");
            dic_de.Add("KK", "5");
            dic_de.Add("DDEE", "6");
            dic_de.Add("DDSS", "7");
            dic_de.Add("DDCC", "8");
            dic_de.Add("DDKK", "9");
            dic_de.Add("EEDD", "0");
            //小写字母
            dic_de.Add("EEEE", "a");
            dic_de.Add("EESS", "b");
            dic_de.Add("EECC", "c");
            dic_de.Add("ECEC", "d");
            dic_de.Add("CKCK", "e");
            dic_de.Add("丁", "f");
            dic_de.Add("真", "g");
            dic_de.Add("丁真", "h");
            dic_de.Add("真丁", "i");
            dic_de.Add("Egroup", "j");
            dic_de.Add("锐", "k");
            dic_de.Add("克", "l");
            dic_de.Add("五", "m");
            dic_de.Add("锐克", "n");
            dic_de.Add("锐克五", "o");
            dic_de.Add("BFF", "p");
            dic_de.Add("FFB", "q");
            dic_de.Add("VVV", "r");
            dic_de.Add("BF", "s");
            dic_de.Add("BFV", "t");
            dic_de.Add("CS", "u");
            dic_de.Add("CSG", "v");
            dic_de.Add("CSGO", "w");
            dic_de.Add("SE", "x");
            dic_de.Add("SEE", "y");
            dic_de.Add("SEEASS", "z");
            dic_de.Add("DONE", "");
            //特殊符号
            dic_de.Add("牛", "/");
            dic_de.Add("UwU", "+");
            dic_de.Add("Not", "=");

            if (args.Length == 0)
            {
                string import = "";
                Console.WriteLine("[信息] {0}", resManager.GetString("argsifempty"));
                Console.WriteLine("[信息] 解密功能，请输入1");
                Console.WriteLine("[信息] 加密功能，请输入2");
                Console.Write("[信息] 请选择功能：");
                import = Console.ReadLine();
                if (import == "1")
                {
                    Console.WriteLine("[信息] 您已选择解密功能");
                    Console.Write("[信息] 请输入密文：");
                    string decode = Console.ReadLine();
                    try
                    {
                        if (debug)
                        {
                            //输入为
                            Console.WriteLine("[DEBUG] 输入文字为：{0}", decode);
                            //BASE64转换
                        }
                        //替换字符
                        List<string> list_de = new List<string>(decode?.Split(' '));
                        //构造字符串
                        StringBuilder builder = new StringBuilder(list_de.Count);
                        for (int i = 0; i < list_de.Count; i++)
                        {
                            //Console.Write("{0} ", dic_de[list_de[i]]);
                            builder.Append(dic_de[list_de[i]]);
                        }
                        //Console.WriteLine("[信息] {0}", builder.ToString());
                        byte[] bytes = System.Convert.FromBase64String(builder.ToString());
                        string decode_de = System.Text.Encoding.UTF8.GetString(bytes);
                        Console.WriteLine("[信息] {0}", decode_de);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[错误] 程序错误，返回内容：{0}", ex);
                    }
                    Console.ReadKey();
                }

                if (import == "2")
                {
                    Console.WriteLine("[信息] 您已选择加密功能");
                    Console.Write("[信息] 请输入明文：");
                    string encode = Console.ReadLine();
                    try
                    {
                        //BASE64编码
                        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(encode);
                        string base64 = System.Convert.ToBase64String(bytes);
                        //处理字符
                        string en_encode = System.Text.RegularExpressions.Regex.Replace(base64, @"(\S|\s)", "$1 ");
                        if (debug)
                        {
                            //分割符添加
                            Console.WriteLine("[DEBUG] 文字处理结果为：{0}", en_encode);
                            //BASE64转换
                            Console.WriteLine("[DEBUG] BASE64处理结果为：{0}", base64);
                        }
                        //替换字符
                        List<string> list = new List<string>(en_encode.Split(' '));
                        Console.Write("[信息]");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write("{0} ", dic[list[i]]);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[错误] 程序错误，返回内容：{0}", ex);
                    }
                    Console.ReadKey();
                }

            }
            else
            {
                if (args[0].Equals("调试") || args[0].Equals("--v"))
                {
                    debug = true;
                };

                if (args[0].Equals("帮助") || args[0].Equals("-h"))
                {
                    Console.WriteLine(resManager.GetString("help"));
                };

                if (args[0].Equals("加密") || args[0].Equals("-e"))
                {
                    Console.WriteLine("[信息] 暂未实现");
                };

                if (args[0].Equals("解密") || args[0].Equals("-d"))
                {
                    Console.WriteLine("[信息] 暂未实现");
                };
            };
            if (debug)
            {
                Console.WriteLine(string.Format("[DEBUG]接收到了{0}个参数", args.Length));//Debug 便于调试，显示接受了几个参数
                foreach (var item in args)//Debug 便于显示输入了什么参数
                {
                    Console.WriteLine(item);
                }
            };
        }
    }
}