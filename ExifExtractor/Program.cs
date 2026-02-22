using MetadataExtractor;

Console.WriteLine("Enter image file path:");
string? imagePath = Console.ReadLine();

if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
{
    Console.WriteLine("Invalid file path.");
    return;
}

try
{
    var directories = ImageMetadataReader.ReadMetadata(imagePath);

    Console.WriteLine("\n===== EXIF METADATA =====\n");

    foreach (var directory in directories)
    {
        foreach (var tag in directory.Tags)
        {
            Console.WriteLine($"{directory.Name} - {tag.Name}: {tag.Description}");
        }

        if (directory.HasError)
        {
            foreach (var error in directory.Errors)
            {
                Console.WriteLine($"ERROR [{directory.Name}]: {error}");
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to read metadata: {ex.Message}");
}

Console.WriteLine("\nDone. Press any key to exit...");
Console.ReadKey();