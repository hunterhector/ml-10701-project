design In order to check for the existence of a bias in the dependency-based metric, we created a set of 4,000 sentences drawn randomly from the SpanishEnglish subset of Europarl (Koehn, 2005), and we produced two translations: one by a rule-based system Logomedia, and the other by the standard phrase-based statistical decoder Pharaoh, using alignments produced by GIZA++8 and the refined word alignment strategy of Och and Ney (2003).
J03-1002
The translation and reference files are analyzed by a treebank-based, probabilistic Lexical-Functional Grammar (LFG) parser (Cahill et al., 2004), which produces a set of dependency triples for each input.
P04-1041
Comparing the LFG-based evaluation method with other popular metrics: BLEU, NIST, General Text Matcher (GTM) (Turian et al., 2003), Translation Error Rate (TER) (Snover et al., 2006)1, and METEOR (Banerjee and Lavie, 2005), we show that combining dependency representations with paraphrases leads to a more accurate evaluation that correlates better with human judgment.
W05-0909
Using the standard GIZA++ software and the refined word alignment strategy of Och and Ney (2003) on our test set of 4,000 Spanish-English sentences, the method generated paraphrases for just over 1100 items.
J03-1002
Callison-Burch et al.(2006) report that BLEU and NIST favour n-gram-based MT models such as Pharaoh (Koehn, 2004), so the translations produced by rule-based systems score lower on the automatic evaluation, even though human judges consistently rate their output higher than Pharaoh’s translation.
E06-1032
83 observed this tendency in previous research as well; in one experiment, reported in Owczarzak et al.(2006), where the rule-based system Logomedia7 was compared with Pharaoh, BLEU scored Pharaoh 0.0349 points higher, NIST scored Pharaoh 0.6219 points higher, but human judges scored Logomedia output 0.19 points higher (on a 5-point scale).
W06-3112
Others try to accommodate both syntactic and lexical differences between the candidate translation and the reference, like CDER (Leusch et al., 2006), which employs a version of edit distance for word substitution and reordering; or METEOR (Banerjee and Lavie, 2005), which uses stemming and WordNet synonymy.
E06-1031 W05-0909
Cahill et al.(2004) presents Penn-II Treebankbased LFG parsing resources.
P04-1041
Second, we want to repeat both experiments using a paraphrase set derived from a large parallel corpus, rather than the test set, as described in Owczarzak et al.(2006). While retaining the advantage of having a similar size to a corresponding set of WordNet synonyms, this set will also capture low-level syntactic variations, which can increase the number of matches and the correlation with human scores.
W06-3112
We introduced synonyms and paraphrases into the process of evaluation, creating new best-matching references for the translations using either paraphrases derived from the test set itself (following Owczarzak et al.(2006)) or WordNet synonyms (as in Kauchak and Barzilay (2006)).
N06-1058 W06-3112
4 3 Related work The insensitivity of BLEU and NIST to perfectly legitimate syntactic and lexical variation has been raised, among others, in Callison-Burch et al.(2006), but the criticism is widespread.
E06-1032
Even the creators of BLEU point out that it may not correlate particularly well with human judgment at the sentence level (Papineni et al., 2002).
P02-1040
Since their appearance, string-based evaluation metrics such as BLEU (Papineni et al., 2002) and NIST (Doddington, 2002) have been the standard tools used for evaluating MT quality.
P02-1040
In addition, to allow for the possibility of valid lexical differences between the translation and the references, we follow Kauchak and Barzilay (2006) and Owczarzak et al.(2006) in adding a number of paraphrases in the process of evaluation to raise the number of matches between the translation and the reference, leading to a higher score.
N06-1058 W06-3112
Bitext-derived paraphrases Owczarzak et al.(2006) describe a simple way to produce a list of paraphrases, which can be useful in MT evaluation, by running word alignment software on the test set that is being evaluated.
W06-3112
In this paper, we use the parser developed by Cahill et al.(2004), which automatically annotates input text with c-structure trees and f-structure dependencies, reaching high precision and recall rates.
P04-1041
Kauchak and Barzilay (2006) and Owczarzak et al.(2006) use paraphrases during BLEU and NIST evaluation to increase the number of matches between the translation and the reference; the paraphrases are either taken from WordNet5 in Kauchak and Barzilay (2006) or derived from the test set itself through automatic word and phrase alignment in Owczarzak et al.(2006). Another metric making use of synonyms is the linear regression model developed by Russo-Lassner et al.(2005), which makes use of stemming, WordNet synonymy, verb class synonymy, matching noun phrase heads, and proper name matching.
N06-1058 W06-3112
WordNet synonyms To maximize the number of matches between a translation and a reference, Kauchak and Barzilay (2006) use WordNet synonyms during evaluation.
N06-1058
