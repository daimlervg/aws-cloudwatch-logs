using CloudWatchLogSample;

//This sample was taken from Ivan Kahl's Blog -> For more detail check the following: https://blog.ivankahl.com/logging-dotnet-to-aws-cloudwatch-using-awssdk/

Console.WriteLine("Starting logger with CloudWatch!!");

var logger = await CloudWatchLogger.GetLoggerAsync("/dev/cmaster/automatic_service");

var infoWarning = "System.Diagnostics.DiagnosticSource.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.";

await logger.LogMessageAsync(infoWarning);

Console.WriteLine("Finised logger with CloudWatch!!");

Console.ReadLine();
