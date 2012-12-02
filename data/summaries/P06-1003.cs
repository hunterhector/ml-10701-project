As shown by (Galley et al., 2003), some of these features can be combined with lexical information to improve segmentation performance (although in a supervised manner), and (Maskey and Hirschberg, 2003) show some success in broadcast news segmentation using only these kinds of non-lexical features.
P03-1071
We show that this model can address these problems over multi-party discourse transcripts, providing good segmentation performance on a corpus of meetings (comparable to the best previous unsupervised method that we are aware of (Galley et al., 2003)), while also inferring a set of topics rated as semantically coherent by human judges.
P03-1071
Our algorithm is related to (Barzilay and Lee, 2004)’s approach to text segmentation, which uses ahiddenMarkovmodel(HMM)tomodelsegmentation and topic inference for text using a bigram representation in restricted domains.
N04-1015
We show how Bayesian inference in this generative model can be used to simultaneously address the problems of topic segmentation and topic identification: automatically segmenting multi-party meetings into topically coherent segments with performance which compares well with previous unsupervised segmentation-only methods (Galley et al., 2003) while simultaneously extractingtopicswhichratehighlywhenassessed for coherence by human judges.
P03-1071
However, one comparable study is described in (Galley et al., 2003).
P03-1071
(Hearst, 1994) uses a measure of lexical cohesion between adjoining paragraphs in text; (Reynar, 1999) and (Beeferman et al., 1999) combine a variety of features such as statistical language modelling, cue phrases, discourse information and the presence of pronouns or named entities to segment broadcast news; (Maskey and Hirschberg, 2003) use entirely non-lexical features.
P94-1002 P99-1046
Galley et al.(2003) annotated these sections explicitly, together with the ICSI “digit-task” sections (participants read sequences of digits to provide data for speech recognition experiments), and removed them from their data, as did we in Experiment 1 above.
P03-1071
Segmentation We assessed segmentation performance using the Pk and WindowDiff (WD) error measures proposed by (Beeferman et al., 1999) and (Pevzner and Hearst, 2002) respectively; both intuitively provide a measure of the probability that two points drawn from the meeting will be incorrectly separated by a hypothesized segment boundary – thus, lower Pk and WD figures indicate better agreement with the human-annotated results.3 For the numbers of segments we are dealing with, a baseline of segmenting the discourse into equal-length segments gives both Pk and WD about 50%.
J02-1002
It alsoperformscomparablyto(Galleyetal.,2003)’s unsupervised performance (exceeding it for some settings of T).
P03-1071
For each set of annotations, we therefore performed two sets of segmentations: one in which the threshold was set for each meeting to give the known goldstandard number of segments, and one in which the threshold was set on a separate development settogivetheoverallcorpus-wideaveragenumber of segments, and held constant for all test meetings.2 This also allows us to compare our results with those of (Galley et al., 2003), who apply a similar threshold to their lexical cohesion function and give corresponding results produced with known/unknown numbers of segments.
P03-1071
Recent advances have used generative models, allowing lexical models of the topics themselves to be built while segmenting (Imai et al., 1997; Barzilay and Lee, 2004), and we take a similar approach here, although with some important differences detailed below.
N04-1015
We then compared performance with (Galley et al., 2003)’s LCSeg tool, and with a 10-state HMM model as described above.
P03-1071
We are also investigating improvements into the lexical model as presented here, firstly via simple techniques such as word stemming and replacement of named entities by generic class tokens (Barzilay and Lee, 2004); but also via the use of multiple ASR hypotheses by incorporating word confusion networks into our model.
N04-1015
For evaluation, we use (Galley et al., 2003)’s set of human-annotated segmentations, which covers a sub-portion of 25 meetings and takes a relatively coarse-grained approach to topic with an average of 5-6 topic segments per meeting.
P03-1071
representation, however, might improve its performance (Barzilay and Lee, 2004), although similar benefits might equally apply to our model.
N04-1015
Hearst. 1994.
P94-1002
