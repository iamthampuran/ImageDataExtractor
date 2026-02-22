# ExifExtractor

A C# console application for extracting and displaying EXIF metadata from image files.

## Description

ExifExtractor is a lightweight utility that reads EXIF metadata from images and displays comprehensive information about the image's properties, such as camera settings, capture date, location data, and other embedded metadata.

## Features

- **EXIF Metadata Extraction**: Reads EXIF data from image files
- **Comprehensive Display**: Shows all available metadata including camera information and capture details
- **Error Handling**: Gracefully handles invalid files and extraction errors
- **User-Friendly Interface**: Simple command-line interface for easy interaction

## Requirements

- **.NET 10** or later
- **C# 14.0** or later

## Dependencies

- **MetadataExtractor** (v2.9.0) - For extracting metadata from images
- **OpenAI** (v2.8.0) - For AI-powered features
- **Microsoft.VisualStudio.Azure.Containers.Tools.Targets** (v1.23.0) - Docker support

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/iamthampuran/ImageDataExtractor.git
   cd ExifExtractor
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

## Usage

1. Run the application:
   ```bash
   dotnet run
   ```

2. When prompted, enter the path to your image file:
   ```
   Enter image file path:
   C:\path\to\your\image.jpg
   ```

3. The application will display all available EXIF metadata organized by category

## Example Output

```
===== EXIF METADATA =====

Exif IFD0 - Make: Canon
Exif IFD0 - Model: Canon EOS 5D
Exif IFD0 - DateTime: 2024:01:15 14:30:45
Exif SubIFD - LensModel: EF 24-70mm f/2.8L II USM
Exif SubIFD - FNumber: f/4.0
Exif SubIFD - ISO Speed Ratings: 400
...

Done. Press any key to exit...
```

## Error Handling

The application handles various error scenarios:

- Invalid or non-existent file paths
- Corrupted or unsupported image formats
- Missing metadata in images
- Read permission issues

## Supported Image Formats

The MetadataExtractor library supports common image formats including:

- JPEG
- PNG
- GIF
- TIFF
- BMP
- ICO
- WEBP

And many more formats depending on the MetadataExtractor version.

## License

This project is part of the ImageDataExtractor repository. Please refer to the repository for license information.

## Repository

- **GitHub**: [ImageDataExtractor](https://github.com/iamthampuran/ImageDataExtractor)

## Contributing

Contributions are welcome! Feel free to submit issues and pull requests to improve the project.

## Troubleshooting

### File Not Found Error

- Ensure the file path is correct and the file exists
- Use absolute file paths for better reliability
- Check file permissions

### No Metadata Displayed

- The image file may not contain EXIF data
- Try with a different image file that contains metadata
- Some image formats may not support EXIF data

### Application Crashes

- Update to the latest version of .NET 10
- Ensure all NuGet packages are properly restored
- Check the error message for specific issues