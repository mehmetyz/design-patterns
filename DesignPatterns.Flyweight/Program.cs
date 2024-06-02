using DesignPatterns.Flyweight;


var COLORS = new[] { "Dark", "White", "Green" };
var TREE_TYPES = new[] { "Evergreen Trees", "Cedar", "Willow" };
var LOCATION = new[] { "PARK", "GARDEN", "FOREST" };


for (int i = 0; i < 10; i++)
{
    var tree = PlatingService.GetTree(RandomFromArray(TREE_TYPES), RandomFromArray(COLORS),
        RandomFromArray(LOCATION));
    
}

return;

string RandomFromArray(IReadOnlyList<string> arr)
{
    return arr[Random.Shared.Next(arr.Count)];
}