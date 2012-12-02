obchodn´ık japonsk´y ...automobilasociace EN2 EN1 EN2 EN1 EN3 Figure 1: Left SPLIT Example parse with the Charniak parser (Charniak, 2000) and convert the resulting phrase-structure trees to a function-argument formalism, which, like the tectogrammatic formalism, removes function words.
A00-2018
The first work on SMT done at IBM (Brown et al., 1990; Brown et al., 1992; Brown et al., 1993; Berger et al., 1994), used a noisy-channel model, resulting in what Brown et al.(1993) call “the Fundamental Equation of Machine Translation”: ˆE =argmaxE P(E)P(F | E) (1) In this equation we see that the translation problem is factored into two subproblems.
H94-1028 J90-2002 J93-2003
• Statistical Phrase-based Translation (Koehn et al., 2003): Here “phrase-based” means “subsequence-based”, as there is no guarantee that the phrases learned by the model will have any relation to what we would think of as syntactic phrases.
N03-1017
• Syntax-based Statistical Translation (Yamada and Knight, 2001): This model extends the above by allowing all possible permutations of the RHS of the English rules.
P01-1067
Model We use a syntax-based language model which was originally developed for use in speech recognition (Charniak, 2001) and later adapted to work with a syntax-based machine translation system (Charniak et al., 2001).
P01-1017
The English data is from the University of Pennsylvania Treebank (Marcus et al., 1993; Marcus et al., 1994).
H94-1020 J93-2004
As a baseline, we will run the GIZA++ implementation of IBM’s Model 4 translation algorithm under the same training conditions as our own system (Al-Onaizan et al., 1999; Och and Ney, 2000; Germann et al., 2001).
P00-1056 P01-1030
We begin by producing word alignments with a model very similar to that of IBM Model 4 (Brown et al., 1993).
J93-2003
In addition to lexical translation, our system models structural changes and changes to feature values, for although dependency structures are fairly well preserved across languages (Fox, 2002), there are certainly many instances where the structure must be modified.
W02-1039
91 2 System Overview The basic framework of our system is quite similar to that of ˇCmejrek et al.(2003) (we reuse many of their ancillary modules).
E03-1004
• Dependency-based Translation ( ˇCmejrek et al., 2003): This model assumes a dependency parser for the foreign language.
E03-1004
• Stochastic Inversion Transduction Grammars (Wu and Wong, 1998): This formalism uses a grammar for English and from it derives a possible grammar for the foreign language.
P98-2230
