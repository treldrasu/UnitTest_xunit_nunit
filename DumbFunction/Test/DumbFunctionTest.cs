namespace DumbFunction;

public class DumbFunctionTest
{
    //Naming - Class_Method_ExpectedResult
    public static void DumbFunction_ReturnHelloWorldIfTrue_ReturnString(){
        //Arrange - Hole dir was du Brauchst
        bool assert = true;
        DumbFunction dumbFunction = new DumbFunction();

        //Act - Ausführen der Function
        String result = dumbFunction.ReturnHelloWorldIfTrue(true);

        //Assert - Prüfe dein ergebniss
        if(result == "Hello World"){
            Console.WriteLine("PASSED: DumbFunction_ReturnHelloWorldIfTrue_ReturnString");
        }else{
            Console.WriteLine("FAILED:  DumbFunction_ReturnHelloWorldIfTrue_ReturnString");
        }
    }
}
