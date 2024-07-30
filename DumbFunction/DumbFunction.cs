namespace DumbFunction;

public class DumbFunction
{
    public string ReturnHelloWorldIfTrue(bool assert){
        if(assert){
            return "Hello World";
        }
        return "";
    }
}
