Eisner (2003) discusses methods for learning synchronized elementary tree pairs from a parallel corpus of parsed sentences.
P03-2041
Modifiers within German clauses were translated using the phrase-based model of Koehn et al.(2003). We first generated n-best lists for each modifier.
N03-1017
Another class of approaches has shown improvements in translation through reordering, where source language strings are parsed and then reordered, in an attempt to recover a word order that is closer to the target language (Collins et al., 2005; Xia and McCord, 2004).
C04-1073 P04-1015 P05-1066
Each list contained the n-best translations produced by the phrase-based system of Koehn et al.(2003). The lists also contained a supplementary candidate “DELETED”, signifying that the modifier should be deleted from the English translation.
N03-1017
The work of Gildea (2003) involves methods that make use of syntactic information in both the source and target languages.
P03-1011
The test data for the experiments consisted of 2,000 sentences, and was the same test set as that used by Collins et al.(2005). We use the model of Koehn et al.(2003) as a baseline for our experiments.
N03-1017 P05-1066
Yamada and Knight (2001) and Galley et al.(2004) describe methods that make use of syntactic information in the target language alone; Quirk et al.(2005) describe similar methods that make use of dependency representations.
N04-1035 P01-1067 P05-1034
AEPs are derived from the concept of an extended projection in lexicalized tree adjoining grammars (LTAG) (Frank, 2002), with the addition of alignment information that is based on work in synchronous LTAG (Shieber and Schabes, 1990).
C90-3045
In this paper, we use the phrase-based system of Koehn et al.(2003) to generate n-best translations for each of the modifiers, and we then use a discriminative reranking algorithm (Bartlett et al., 2004) to choose between these modifiers.
N03-1017
Our approach is closely related to previous work on synchronous tree adjoining grammars (Shieber and Schabes, 1990; Shieber, 2004), and the work on TAG approaches to syntax described by Frank (2002).
C90-3045
For each sentence pair from this data, we used a version of the German parser described by Dubey (2005) to parse the German component, and a version of the English parser described by Collins (1999) to parse the English component.
P05-1039
Chiang (2005) has recently shown significant improvements in translation accuracy, using synchronous grammars.
P05-1033
Melamed 2004.
P04-1083
Melamed (2004) establishes a theoretical framework for generalized synchronous parsing and translation.
P04-1083
Riezler and Maxwell (2006) describe a method for learning a probabilistic model that maps LFG parse structures in German into LFG parse structures in English.
N06-1032
tic information through reranking approaches applied to n-best output from phrase-based systems (Och et al., 2004).
J04-4002 N04-1021
This combination of the perceptron algorithm with beam-search is similar to that described by Collins and Roark (2004).5 The perceptron algorithm is a convenient choice because it converges quickly — usually taking only a few iterations over the training set (Collins, 2002; Collins and Roark, 2004).
P04-1015 W02-1001
An evaluation of the method on translation from German to English shows similar performance to the phrase-based model of Koehn et al.(2003). 1 Introduction Phrase-based approaches (Och and Ney, 2004) to statistical machine translation (SMT) have recently achieved impressive results, leading to significant improvements in accuracy over the original IBM models (Brown et al., 1993).
J04-4002 J93-2003 N03-1017 N04-1021
Evaluation in terms of both BLEU scores and human judgments shows that our system performs similarly to the phrase-based model of Koehn et al.(2003). 1.1 A Sketch of the Approach This section provides an overview of the translation process.
N03-1017
Alshawi. 1996.
P96-1023
To extract AEPs, we perform the following steps: NP and PP Alignment To align NPs and PPs, first all German and English nouns, personal and possessive pronouns, numbers, and adjectives are identified in each sentence and aligned using GIZA++ (Och and Ney, 2003).
J03-1002
To train the model, we use the averaged perceptron algorithm described by Collins (2002).
W02-1001
Wu (1997) and Alshawi (1996) describe early work on formalisms that make use of transductive grammars; Graehl and Knight (2004) describe methods for training tree transducers.
J97-3002 N04-1014 P96-1023
In this paper, we implement the translation of modifiers (Step 3) with the phrase-based system of Koehn et al.(2003). The modifiers in our data set are generally small chunks of text such as NPs, PPs, and ADJPs, which by definition do not include clauses or verbs.
N03-1017
Yamada. 2001.
P01-1067
