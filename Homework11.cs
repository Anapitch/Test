using System;
					
public class Program
{
	public static void Main()
	{
            string bahtTxt, n, bahtTH = "" ,str="";
            double amount;
			bool Trillion = false;
			Console.WriteLine("��͡����Ţ");
			bahtTH = Console.ReadLine();
            try { amount = Convert.ToDouble(bahtTH); }
            catch { amount = 0; }
			bahtTH = "";
            bahtTxt = amount.ToString("####.00");
            string[] num = {"�ٹ��", "˹��", "�ͧ", "���", "���", "���", "ˡ", "��", "Ỵ", "���", "�Ժ"};
            string[] rank = { "", "�Ժ", "����", "�ѹ", "����", "�ʹ", "��ҹ" };
            string[] temp = bahtTxt.Split('.');
            string intVal = temp[0];
            string decVal = temp[1];
            if (Convert.ToDouble(bahtTxt) == 0)
                bahtTH = "�ٹ��ҷ��ǹ";
            else
            {   
				if(intVal.Length > 7){
					Trillion = true;
					str = intVal.Substring(0, intVal.Length - 6);
					intVal = intVal.Substring(str.Length);
					for (int i = 0; i < str.Length; i++) //ǹ�ٻ����Ţ�ҡ����仢��
					{
						n = str.Substring(i, 1); //�֧��ҵ���Ţ 1 ����������� n
						if (n != "0")
						{
							if(str.Length == 1){ //��ҵ���Ţ����͡�ҷ����� �դ������ 1 ��ѡ
								bahtTH += num[Convert.ToInt32(n)]; //������� bahtTH �դ�� += num
							}else{

							if ((i == (str.Length - 1)) && (n == "1"))
								bahtTH += "���";
							else if ((i == (str.Length - 2)) && (n == "2"))
								bahtTH += "���";
							else if ((i == (str.Length - 2)) && (n == "1")){
								bahtTH += "";
							}else
								bahtTH += num[Convert.ToInt32(n)];
								bahtTH += rank[(str.Length - i) - 1];

							}
						}
					}
				}
                for (int i = 0; i < intVal.Length; i++) //ǹ�ٻ����Ţ�ҡ����仢��
                {
                    n = intVal.Substring(i, 1); //�֧��ҵ���Ţ 1 ����������� n
                    if (n != "0")
                    {
						if(intVal.Length == 1){ //��ҵ���Ţ����͡�ҷ����� �դ������ 1 ��ѡ
							bahtTH += num[Convert.ToInt32(n)]; //������� bahtTH �դ�� += num
						}else{
							
					 	if ((i == (intVal.Length - 1)) && (n == "1"))
                            bahtTH += "���";
                        else if ((i == (intVal.Length - 2)) && (n == "2"))
                            bahtTH += "���";
                        else if ((i == (intVal.Length - 2)) && (n == "1")){
                            bahtTH += "";
						}else
                            bahtTH += num[Convert.ToInt32(n)];
                        	bahtTH += rank[(intVal.Length - i) - 1];
							
						}
						
                     
                    }
                }
			 if (Trillion)
			{
				bahtTH += "��ҹ";
			}

            Console.WriteLine(bahtTH);
		}
	}
}