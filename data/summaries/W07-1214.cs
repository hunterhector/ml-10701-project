(Rosario and Hearst, 2001; Moldovan et al., 2004; Kim and Baldwin, 2005) use supervised methods and explore classification features from a simple structured type hierarchy.
W05-1008
In parsing, for example, symbolic grammars are combined with stochastic models (Oepen et al., 2004; Malouf and van Noord, 2004).
P04-1057
2.2 Log-linear models for disambiguation Since Johnson et al.(1999), log-linear models of the following form have become standard as disambiguation devices for precision grammars: P(x|y) = e summationtextm j=1 jfj(x,y) summationtext xprime?X(y) e summationtextm j=1 jfj(xprime,y) They are used for parse selection in the English Resource Grammar (Toutanova et al., 2002), the English ParGram LFG (Riezler et al., 2002), the English Enju HPSG (Miyao and Tsujii, 2002), the HPSG-inspired Alpino parser for Dutch (Malouf and van Noord, 2004; van Noord, 2006) and the English CCG from Edinburgh (Clark and Curran, 2004).
P04-1057
Baldwin. 2005.
W05-1008 W05-1008
Details can be found in Brants (2000) and Samuelson (1993).
A00-1031
We have trained the DT with all the vectors of the word occurrences that we had in the different gold-standards, using their encoding for the supervised experiment in a 10-fold cross-validation testing (Bel et al.2007). 3.3 Evaluation and Results For the evaluation, we have applied both methods to the lexical acquisition of nouns and adjectives.
N07-2002
2 Pre-processing in the SRG Following previous experiments within the Advanced Linguistic Engineering Platform (ALEP) platform (Marimon, 2002), we have integrated a shallow processing tool, the FreeLing tool, as a pre-processing module of the grammar.
C02-1071
Korhonen (2002), Carroll and Fang (2004), Baldwin (2005), Blunsom and Baldwin (2006), and Zhang and Kordoni (2006) are just a few examples of reported research work on deep lexical acquisition.
W05-1008 W06-1620
Our error reduction of 51.0% also compares favorably to the 36% error reduction on English LFG parses reported in Riezler et al.(2002). However, it is considerably lower than the error reduction of 78% reported for the Dutch Alpino parser (Malouf and van Noord, 2004), but this may be due to the fact that our lower bound is calculated on the basis of analyses that have already passed a prefilter and is thus relatively high.
P04-1057
This way, we hope to extract the information necessary to model the tendencies observed, e.g., in Uszkoreit et al.(1998). 3.4 Lexicalized properties capturing dependencies Inspired by Malouf and van Noord (2004), we finally also introduced lexicalized properties capturing dependencies.
P04-1057
Furthermore, in order to estimate the relative performance of the models, experiments were carried out with two existing taggers: TnT (Brants, 2000) and ACOPOST 3 . The accuracy achieved using TnT are 87.44% and 87.36% respectively with bigram and trigram model for 40K training data.
A00-1031
Many researchers have recently developed methods for the automatic acquisition of various properties of MWEs from corpora (Lin, 1999; Krenn and Evert, 2001; Baldwin et al., 2003; McCarthy et al., 2003; Venkatapathy and Joshi, 2005; Villada Moiron and Tiedemann, 2006; Fazly and Stevenson, 2006).
W05-1008
The only similar performing tool is the Trigrams `n' Tags tagger (Brants, 2000) which uses a much simpler statistical model.
A00-1031
Brants. 2000.
A00-1031
??The development of error mining techniques (van Noord, 2004) to identify erroneous and incomplete information in the linguistic resources which cause the grammar to fail.
P04-1057
Such relations are usually represented as a set of taxonomic categories; for example the meaning of STUDENT LOAN might be specified with a POSSESSOR relation (Kim & Baldwin, 2005) or MILK COW might be specified by a MAKES relation (Gagne & Shoben, 1997).
W05-1008
Levi, 1977; Kim & Baldwin, 2005).
W05-1008
Bender. 2002.
W02-1502
The SRG is implemented within the Linguistic Knowledge Building (LKB) system (Copestake, 2002), based on the basic components of the grammar Matrix, an open?source starter-kit for the development of HPSG grammars developed as part of the LinGO consortium?s multilingual grammar engineering (Bender et al., 2002).
W02-1502
For the most part, these features are clever hacks, and it is unfortunate that neither Brants (2000) nor the standard HMM textbooks mention them, especially as they often yield more significant error reduction than the move from HMM to other architectures.
A00-1031
Stochastic models (Cutting et al., 1992; Dermatas et al., 1995; Brants, 2000) have been widely used in POS tagging for simplicity and language independence of the models.
A00-1031
Gagne & Shoben, 1997; Kim & Baldwin, 2005).
W05-1008
The grammar is an HPSG implementation (JACY: Siegel and Bender, 2002), which provides a high level of detail, marking not only dependency and constituent structure but also detailed semantic relations.
W02-1502
33. oravecz@nytud.hu Abstract In the world of non-proprietary NLP software the standard, and perhaps the best, HMM-based POS tagger is TnT (Brants, 2000).
A00-1031
Even without a formal survey it is clear that TnT (Brants, 2000) is used widely in research labs throughout the world: Google Scholar shows over 400 citations.
A00-1031
One popular approach is to use a log-linear parsing model and maximise the conditional likelihood function (Johnson et al., 1999; Riezler et al., 2002; Clark and Curran, 2004b; Malouf and van Noord, 2004; Miyao and Tsujii, 2005).
P04-1057
