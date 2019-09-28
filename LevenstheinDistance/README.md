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

- Use the method to calculate distance and similarity. By default the method returns the distance and similarity values, but you may not return one of the metrics
```csharp

	// Method that calculates string distance and similarity
    var bothCalc = new LevenshteinInput(reference, exampleList);
    var data = bothCalc.CallLevenstheinCalc(similarity:true, distance:true);

	// Console Response Sample

	// example
	// -------------------
	// example 1
	// Distance: 2,00 | Similarity: 77,78%

	// example 2
	// Distance: 2,00 | Similarity: 77,78%

	// example 3
	// Distance: 2,00 | Similarity: 77,78%
```
- Use the method to calculate similarity only
```csharp

	// Method that calculates similarity only
		var similarityCalc = new LevenshteinInput(reference, exampleList);
		var data = similarityCalc.CallLevenstheinCalc(similarity:true, distance:false);


	// Console Response Sample

	// example
	// -------------------
	// example 1
	// Similarity: 77,78%

	// example 2
	// Similarity: 77,78%

	// example 3
	// Similarity: 77,78%

```
- Use the method to calculate distance only

```csharp
	// Method that calculates only the distance
	var distanceCalc = new LevenshteinInput(reference, exampleList);
	var data = distanceCalc.CallLevenstheinCalc(similarity:false, distance:true);

	// Console Response Sample

	// example
	// -------------------
	// example 1
	// Distance: 2,00

	// example 2
	// Distance: 2,00

	// example 3
	// Distance: 2,00

```
