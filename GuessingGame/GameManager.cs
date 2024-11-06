public class GameManager {

    private readonly INumberGenerator _numberGenerator;

    public GameManager(INumberGenerator number) {

        _numberGenerator = _numberGenerator;
    }

    public void InitGame(){

        int numberToGuess = _numberGenerator.GenerateNumber();
        Console.WriteLine($"Number to guess is: {numberToGuess}");
        
    }
}