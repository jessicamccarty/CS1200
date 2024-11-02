

public class Temperature {


    // Store the value of kelvin
    private double Kelvin; 

    // Kelvin Property
    public double kelvin {

        get { return kelvin; } // Return the value of Kelvin
        set {

            // Check if value is less than 0
            if (value < 0) {
                kelvin = 0; // Set to 0 if it's negative
            } else {
                kelvin = value; // Set to provided value
            }
        }

    }


    // Celsius Property
    public double Celsius {
        get {
            return kelvin - 273.15; // Convert to celsius
        } 
    }


    // Farenheit Property

    public double Farenheit {
        get {
            return Celsius * 9 / 5 + 32; // Convert to farenheit
        }
    }
    


}