We used the pseudo-projective transformation introduced in (Nivre and Nilsson, 2005) to cast non-projective parsing tasks as projective.
P05-1013
To overcome a minor shortcoming of the parsing algorithm of (Nivre et al., 2004) we introduce a simple language independent post-processing step.
W04-2407
The fact that our model defines a probability model over parse trees, unlike the previous stateof-the-art methods (Nivre et al., 2006; McDonald et al., 2006), makes it easier to use this model in applications which require probability estimates, such as in language processing pipelines or for language modeling.
W06-2932 W06-2933
CoNLL-X shared task (Buchholz and Marsi, 2006).
W06-2920
To search for the most probable parse, we use the heuristic search algorithm described in (Titov and Henderson, 2007b), which is a form of beam search.
P07-1080 W07-2218
We evaluated the ISBN parser on all the languages considered in the shared task (Hajiˇc et al., 2004; Aduriz et al., 2003; Mart´ı et al., 2007; Chen et al., 2003; B¨ohmov´a et al., 2003; Marcus et al., 1993; Johansson and Nugues, 2007; Prokopidis et al., 2005; Csendes et al., 2005; Montemagni et al., 2003; Oflazer et al., 2003).
J93-2004
Also, as with any generative model, it should be easy to improve the parser’s accuracy with discriminative reranking, such as discriminative retraining techniques (Henderson, 2004) or data-defined kernels (Henderson and Titov, 2005), with or even without the introduction of any additional linguistic features.
P04-1013 P05-1023
ISBNs, originally proposed for constituent parsing in (Titov and Henderson, 2007a), use vectors of binary latent variables to encode information about the parse history.
P07-1080 W07-2218
In fact, in (Titov and Henderson, 2007a) it was shown that this neural network can be viewed as a coarse approximation to the corresponding ISBN model.
P07-1080 W07-2218
This curve plots the average labeled attachment score over Basque, Chinese, English, and Turkish as a function of parsing time per token.4 Accuracy of only 1% below the maximum can be achieved with average processing time of 17 ms per token, or 60 tokens per second.5 We also refer the reader to (Titov and Henderson, 2007b) for more detailed analysis of the ISBN dependency parser results, where, among other things, it was shown that the ISBN model is especially accurate at modeling long dependencies.
P07-1080 W07-2218
We use a recently proposed dependency parser (Titov and Henderson, 2007b)1 which has demonstrated state-of-theart performance on a selection of languages from the 1The ISBN parser will be soon made downloadable from the authors’ web-page.
P07-1080 W07-2218
In this they are similar to the class of neural networks proposed in (Henderson, 2003) for constituent parsing.
N03-1014
As was demonstrated in (Titov and Henderson, 2007b), even a minimal set of local explicit features achieves results which are non-significantly different from a carefully chosen set of explicit features, given the language independent definition of locality described in section 2.
P07-1080 W07-2218
Unlike (Titov and Henderson, 2007b), in the shared task we used only the simplest feed-forward approximation, which replicates the computation of a neural network of the type proposed in (Henderson, 2003).
N03-1014 P07-1080 W07-2218
Probability Model Our probability model uses the parsing order proposed in (Nivre et al., 2004), but instead of performing deterministic parsing as in (Nivre et al., 2004), this ordering is used to define a generative historybased model, by adding word prediction to the Shift parser action.
W04-2407
For Arabic, Chinese, and Czech, we used the same feature models used in the CoNLL-X 948 shared task by (Nivre et al., 2006), and for Turkish we used again the base feature model but extended it with a single feature: the part-of-speech tag of the token preceding the current top of the stack.
W06-2933
Exact inference in ISBN models is not tractable, but effective approximations were proposed in (Titov and Henderson, 2007a).
P07-1080 W07-2218
We used the base feature model defined in (Nivre et al., 2006) for all the languages but Arabic, Chinese, Czech, and Turkish.
W06-2933
When conditioning on words, we treated each word feature individually, as this proved to be useful in (Titov and Henderson, 2007b).
P07-1080 W07-2218
The multilingual track of the CoNLL-2007 shared task (Nivre et al., 2007) considers dependency parsing of texts written in different languages.
D07-1096
In our experiments we use the same definition of structural locality as was proposed for the ISBN dependency parser in (Titov and Henderson, 2007b).
P07-1080 W07-2218
Following (Nivre et al., 2006), the encoding scheme called HEAD in (Nivre and Nilsson, 2005) was used to encode the original non-projective dependencies in the labels of the projectivized dependency tree.
P05-1013 W06-2933
We would expect better performance with the more accurate approximation based on variational inference proposed and evaluated in (Titov and Henderson, 2007a).
P07-1080 W07-2218
