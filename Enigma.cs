using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

public class EnigmaMachine
{
    private readonly List<Rotor> rotors;
    private readonly Reflector reflector;

    public EnigmaMachine()
    {
        rotors = new List<Rotor>
        {
            new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q'), // Rotor I
            new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E'), // Rotor II
            new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V')  // Rotor III
        };

        reflector = new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT"); // Reflector B
    }

    public void SetRotorPositions(string positions)
    {
        for (int i = 0; i < positions.Length && i < rotors.Count; i++)
            rotors[i].SetPosition(positions[i]);
    }

    public string Process(string input)
    {
        string output = "";

        foreach (char ch in input.ToUpper())
        {
            if (!char.IsLetter(ch))
            {
                output += ch; // Dejar espacios, signos, etc.
                continue;
            }

            StepRotors();

            char encoded = ch;

            foreach (var rotor in rotors)
                encoded = rotor.EncodeForward(encoded);

            encoded = reflector.Reflect(encoded);

            for (int i = rotors.Count - 1; i >= 0; i--)
                encoded = rotors[i].EncodeBackward(encoded);

            output += encoded;
        }

        return output;
    }

    private void StepRotors()
    {
        bool stepNext = rotors[0].Rotate();

        for (int i = 1; i < rotors.Count; i++)
        {
            if (stepNext)
                stepNext = rotors[i].Rotate();
            else
                break;
        }
    }
}

public class Rotor
{
    private readonly string wiring;
    private readonly char notch;
    private int position;

    public Rotor(string wiring, char notch)
    {
        this.wiring = wiring;
        this.notch = notch;
        position = 0;
    }

    public void SetPosition(char c)
    {
        position = c - 'A';
    }

    public bool Rotate()
    {
        position = (position + 1) % 26;
        return GetCurrentLetter() == notch;
    }

    private char GetCurrentLetter()
    {
        return (char)('A' + position);
    }

    public char EncodeForward(char c)
    {
        int index = (c - 'A' + position) % 26;
        return (char)((wiring[index] - 'A' - position + 26) % 26 + 'A');
    }

    public char EncodeBackward(char c)
    {
        int index = (c - 'A' + position + 26) % 26;
        int mapped = wiring.IndexOf((char)('A' + index));
        return (char)((mapped - position + 26) % 26 + 'A');
    }
}

public class Reflector
{
    private readonly string wiring;

    public Reflector(string wiring)
    {
        this.wiring = wiring;
    }

    public char Reflect(char c)
    {
        return wiring[c - 'A'];
    }
}
