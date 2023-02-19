# Coding Task for HGI
-----------------

## Getting Started
===============
1. Clone repository from [Github](https://github.com/ebuka-olisa/hgi-coding-task.git).
2. Install requirements `dotnet build`.

## Testing
=======
The "TestClass" file handles automatic testing of several use cases. Edit the test conditions using paths to files within your computer/network and the passing conditions for each file. It is also important to note that the file paths must be absolute paths.
The command to run the test cases is `dotnet test`.

## Running the Application
=======================
The application can be run in the command prompt using the following command
`dotnet run -- <task_id> <file_path>`
The **"task_id"** is a number that represents the task to be performed. Enter **1** to count the number of sequences or **2** to count the total number of nucleotides.
The **"file_path"** is the absolute path to the file the FASTQ file (plain or compressed). (Note: Place the file_path in double quotations if it contains whitespace characters)
