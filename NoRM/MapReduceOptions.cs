
namespace Norm
{
    /// <summary>
    /// The map reduce options.
    /// </summary>
    public class MapReduceOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceOptions"/> class.
        /// </summary>
        public MapReduceOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapReduceOptions"/> class.
        /// </summary>
        /// <param name="collectionName">
        /// The collection name.
        /// </param>
        public MapReduceOptions(string collectionName)
        {
            this.CollectionName = collectionName;
        }

        /// <summary>
        /// Gets or sets Map.
        /// </summary>
        public string Map { get; set; }

        /// <summary>
        /// Gets or sets Reduce.
        /// </summary>
        public string Reduce { get; set; }

        /// <summary>
        /// Gets or sets CollectionName.
        /// </summary>
        public string CollectionName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Permenant.
        /// </summary>
        public bool Permenant { get; set; }

        /// <summary>
        /// Gets or sets OutputCollectionName.
        /// </summary>
        public string OutputCollectionName { get; set; }

        /// <summary>
        /// Gets or sets Limit.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets Finalize.
        /// </summary>
        public string Finalize { get; set; }
    }
}