Zitouni et al.(2006) use a maximum entropy classifier to assign a set of diacritics to the letters of each word.
P06-1073
To our knowledge, no results on diacritization have been previously reported using this particular approach to tagging.4 In this paper, we extend our basic MADA system in the following ways: First, we follow Hajiˇc et al.(2005) in including case, mood, and nunation 4Smith et al.(2005) also use the Buckwalter Analyzer in their Arabic morphological tagger, but then use a rather different approach to choosing among the possible analyses.
H05-1060
We train our classifiers on the exact training set defined by Zitouni et al.(2006), a subpart of the third segment of the Penn Arabic Treebank (Maamouri et al., 2004) (“ATB3-Train”, 288,000 words).
P06-1073
The algorithm we proposed in (Habash and Rambow, 2005) for choosing the best BAMA analysis simply counts the number of predicted values for the set of linguistic features in each candidate analysis.
P05-1071
This is because we are choosing among complete diacritization options for white space-tokenized words, while Zitouni et al.(2006) make choices for each diacritic.
P06-1073
Thus, while many of the same elements are used in their and our work (word n-grams, features related to morphological analysis), the basic approach is quite different: while we have one procedure that chooses a correct analysis (including toAll Diacritics Ignore Last Model WER DER WER DER Only-DLM-1 39.4 14.5 13.8 6.6 Tagger-DLM-1 15.9 5.3 6.2 2.5 Tagger-DLM-2 15.2 5.1 5.8 2.4 Tagger-DLM-3 15.1 5.0 5.7 2.4 Tagger-LLM-1 16.0 5.3 6.3 2.6 Tagger-LLM-2 15.0 4.9 5.6 2.2 Tagger-LLM-3 14.9 4.8 5.5 2.2 Only-LLM-3 35.5 10.8 8.8 3.6 Tagger-noLM 16.0 5.3 6.3 2.6 Zitouni 18.0 5.5 7.9 2.5 Figure 1: Diacritization Results (all followed by single-choice-diac model); our best results are shown in boldface; Only-DLM-1 is the baseline; “Zitouni” is (Zitouni et al., 2006) kenization, morphological tag, and diacritization), they have a pipeline of processors.
P06-1073
Work We review three approaches that are directly relevant to us; we refer to the excellent literature review in (Zitouni et al., 2006) for a general review.
P06-1073
In order to assure maximal comparability with the work of Zitouni et al.(2006), we adopt their metric.5 We count all words, including numbers and punctuation.
P06-1073
Vergyri and Kirchhoff (2004) follow an approach similar to ours in that they choose from the diacritizations proposed by BAMA.
W04-1612
A more detailed presentation can be found in (Habash and Rambow 2007).
N07-2014
Second, we replace the YAMCHA (Kudo and Matsumoto, 2003) implementation of Support Vector Machines (SVMs) with SVMTool (Gim´enez and M`arquez, 2004) as our machine learning tool, for reasons of speed, at the cost of a slight decrease in accuracy.
P03-1004
MADA-D System In a previous publication, we described the Morphological Analysis and Disambiguation of Arabic (MADA) system (Habash and Rambow, 2005).
P05-1071
We also note the issue of unknown words, which will affect our system much more than that of (Zitouni et al., 2006).
P06-1073
Furthermore, Zitouni et al.(2006) do not use a morphological lexicon.
P06-1073
Finally, we give the results of Zitouni et al.(2006) on the last line, which we understand to be the best published results currently.
P06-1073
