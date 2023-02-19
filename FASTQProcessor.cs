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

            // Division by 4 must only be done on a number that is not zero
            if(nonBlankLineCounter > 0)
                return nonBlankLineCounter / 4;
            else
                return 0;
        }

        // Calculates the total number of nucleotides in a FASTQ file
        public static int NumberOfNucleotides(string filePath){
            int nucleotideCount = 0;

            // flag to indicate if we have started reading a new sequence in the file
            bool newSequenceStarted = false;

            // Read the file one line at a time
            // This helps with memory management
            foreach(string line in File.ReadLines(filePath))
            {
                if(!string.IsNullOrWhiteSpace(line) && line.StartsWith("@"))
                {
                    newSequenceStarted = true;
                    continue;
                }

                if(newSequenceStarted)
                {
                    nucleotideCount += line.Length; // add length of this nucleotide to the total count
                    newSequenceStarted = false;
                }
            }

            return nucleotideCount;
        }
    }
}