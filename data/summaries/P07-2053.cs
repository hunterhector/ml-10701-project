The only similar performing tool is the Trigrams `n' Tags tagger (Brants, 2000) which uses a much simpler statistical model.
A00-1031
seen unseen overall TnT 96.77% 85.91% 96.46% HunPos 1 96.76% 86.90% 96.49% HunPos 2 96.88% 86.13% 96.58% Table 2: WSJ tagging accuracy, HunPos with first and second order emission/lexicon probabilities If we follow Banko and Moore (2004) and construct a full (no OOV) morphological lexicon from the tagged version of the test corpus, we obtain 96.95% precision where theirs was 96.59%.
C04-1080
Though taggers based on dependency networks (Toutanova et al., 2003), SVM (Gimenez and M`arquez, 2003), MaxEnt (Ratnaparkhi, 1996), CRF (Smith et al., 2005), and other methods may reach slightly better results, their train/test cycle is orders of magnitude longer.
H05-1060 N03-1033 W96-0213
Note that this decoding is an equivalent formulation to a uniformly weighted logarithmic opinion pool, as described in Smith et al.(2005). Of the three decoding methods, Standalone has the lowest complexity, requiring only a binary Viterbi decoding for each weak learner.
H05-1060
As we said at the out211 set, we don?t necessarily believe HunPos to be in any way better than TnT, and certainly the main ideas have been pioneered by DeRose (1988), Church (1988), and others long before this generation of HMM work.
A88-1019 J88-1003
This result exceeds Lafferty et al.'s accuracy of 95.73% using a CRF but falls short of Toutanova et al.(2003)'s state-of-the-art 97.24%.
N03-1033
33. oravecz@nytud.hu Abstract In the world of non-proprietary NLP software the standard, and perhaps the best, HMM-based POS tagger is TnT (Brants, 2000).
A00-1031
Even without a formal survey it is clear that TnT (Brants, 2000) is used widely in research labs throughout the world: Google Scholar shows over 400 citations.
A00-1031
For the most part, these features are clever hacks, and it is unfortunate that neither Brants (2000) nor the standard HMM textbooks mention them, especially as they often yield more significant error reduction than the move from HMM to other architectures.
A00-1031
DeRose. 1988.
J88-1003
(In fact, HunPos can handle a context window of any size, but on the limited training sets available to us increasing this parameter beyond 2 gives no further improvement.) As for contextualized lexical probabilities, our extension is very similar to Banko and Moore (2004) who use P(wi|ti??,ti,ti+1) lexical probabilities and found, on the Penn Treebank, that ?incorporating more context into an HMM when estimating lexical probabilities improved accuracy from 95.87% to 96.59%??
C04-1080
Hungarian We evaluated the different models by tenfold cross-validation on the Szeged Corpus (Csendes et al., 2004), with the relevant data in presented Table 3.
W04-1903
The reason why Banko and Moore (2004) get less than HunPos is not because their system is inherently worse, but rather because it lacks the engineering hacks built into TnT and HunPos.
C04-1080
One difficulty with their approach, noted by Banko and Moore (2004), is the treatment of unseen words: their method requires a full dictionary that lists what tags are possible for each word.
C04-1080
