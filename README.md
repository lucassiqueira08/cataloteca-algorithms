# Cataloteca Algorithms

Library with machine learning algorithms from the 'cataloteca' project.

## Levenshtein Distance
Algorithm used to calculate the distance and similarity between two strings.

**How to use Levenshtein Distance Algorithm?**

- Use Leveshtein project
```csharp
	using cataloteca.algorithms.LevenshteinDistance;
```

- Define your **reference**, ie the string you want to compare with your data.
```csharp
	string reference = "Example";
```

- Define your targets, ie the data you want to compare with the reference.
```csharp
	List<string> exampleList = new List<string>(new string[] {
        "example 1",
        "example 2",
        "example 3"
    });
```
- Choose the method to call.
```csharp

	// Method that calculates string distance and similarity
    var bothCalc = new LevenshteinInput(reference, productsList);
    var data = bothCalc.CallLevenstheinCalc();

	// Method that calculates similarity only
    var similarityCalc = new LevenshteinInput(reference, productsList);
    var data = similarityCalc.CallLevenstheinSimilarity();

	// Method that calculates only the distance
    var distanceCalc = new LevenshteinInput(reference, productsList);
    var data = distanceCalc.CallLevenstheinDistance();
```

**Author: Lucas Alves Siqueira**