using DesignPatterns.Decorator;

IFileUploader fileUploader = new FileUploader();
fileUploader = new CompressionDecorator(fileUploader);
fileUploader = new EncryptionDecorator(fileUploader);

await using var stream = new MemoryStream(); 
await fileUploader.Upload("file.txt", stream);

Console.WriteLine();
