// See https://aka.ms/new-console-template for more information

using System.Text;

//var tests = File.ReadAllLines("./tests.txt").ToList();

var s = "42";

Console.WriteLine(Leet.MyAtoi(1));


static class Leet
{
    public static int MyAtoi(string str) {
     
        string temp = str;
        temp = temp.Trim();
        if(string.IsNullOrEmpty(temp)) return 0;

        bool isNeg = false;
        if(temp[0] == '-' || temp[0] == '+'){
            if (temp[0] == '-'){
                isNeg = true;
            }

            temp = temp.Remove(0,1);
        }   
        
        bool hitnonzero = false;
        StringBuilder sb = new StringBuilder();
        for(int i =0; i< temp.Length; i++){
            if(temp[i] == '0' && !hitnonzero){
                    
            }
            else{
                if(!char.IsDigit(temp[i])){
                    break;
                }
                hitnonzero = true;
                sb.Append(temp[i]);
            }
        }
        if(string.IsNullOrEmpty(sb.ToString())) return 0;
        
        if(Convert.ToDouble(sb.ToString()) > int.MaxValue){
            if(isNeg) return int.MinValue;
            else return int.MaxValue;
        }
        else{
            if(isNeg) return Convert.ToInt32(sb.ToString())*-1;
            else return Convert.ToInt32(sb.ToString());
        }
    }
}