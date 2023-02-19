namespace HGICodingTask
{
    public class FASTQProcessor
    {
        // Calculates the number of sequences in a FASTQ file
        public static int NumberOfSequences(string filePath){
            int nonBlankLineCounter = 0;

            // Read the file one line at a time
            // This helps with memory management
            foreach(string line in File.ReadLines(filePath))
            {
                // increase this count if the line found is not blank
                if(!string.IsNullOrWhiteSpace(line))
                {
                    nonBlankLineCounter++;
                }
            }

            if(nonBlankLineCounter > 0)
                return nonBlankLineCounter / 4;
            else
                return 0;
        }

        public static int NumberOfNucleotides(string filePath){
            int nucleotideCount = 0;
            return nucleotideCount;
        }
    }
}