namespace FacadePattern
{
    public class VideoConverter
    {
        public VideoFile Convert(string filename, string format)
        {
            var file = new VideoFile(filename);
            
            var sourceCodec = new CodecFactory().Extract(file);

            ICodec destinationCodec;

            if (format == "mp4")
            {
                destinationCodec = new Mpeg4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }

            var buffer = BitrateReader.Read(filename, sourceCodec);

            var result = BitrateReader.Convert(buffer, destinationCodec);

            result = new AudioMixer().Fix(result);

            return new VideoFile(result);
        }
    }
}