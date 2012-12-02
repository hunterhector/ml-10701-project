The similarity-based system of Dagan, Pereira, and Lee (1994) improves a baseline Turing-Good bigram model by 2.4% and the co-occurrence system of Essen and Steinbiss (1992) leads to a 10% improvement over an interpolated baseline bigram model.
P94-1038
Successful approaches aimed at trying to overcome the sparse data limitation include backoff (Katz 1987), Turing-Good variants (Good 1953; Church and Gale 1991), interpolation (Jelinek 1985), deleted estimation (Jelinek 1985; Church and Gale 1991), similarity-based models (Dagan, Pereira, and Lee 1994; Essen and Steinbiss 1992), Pos-language models (Derouault and Merialdo 1986) and decision tree models (Bahl et al.1989; Black, Garside, and Leech 1993; Magerman 1994).
P93-1005 P94-1038
In contrast, we present the structural tag representation, where the symbol representing the word simultaneously represents the classification of that word (McMahon and Smith \[1994\] make connections between this and other representations; Black et al.\[1993\] contains the same idea applied to the field of probabilistic parsing; also structural tags can be considered a subclass of the more general tree-based statistical language model of Bahl et al.\[1989\]). In our model, each word is represented by an s-bit number the most significant bits of which correspond to various levels of classification; so given some word represented as structural tag w, we can gain immediate access to all s levels of classification of that word.
P93-1005
Much research has been carried out recently in this area (Hughes and Atwell 1994; Finch and Chater 1994; Redington, Chater, and Finch 1993; Brill et al.1990; Kiss 1973; Pereira and Tishby 1992; Resnik 1993; Ney, Essen, and Kneser 1994; Matsukawa 1993).
H90-1055 H93-1049 P93-1024
The system of Pereira and Tishby (1992; Pereira, Tishby, and Lee 1993) has the added advantage that class membership is probabilistic rather than fixed.
P93-1024
1. Introduction Many applications that process natural language can be enhanced by incorporating information about the probabilities of word strings; that is, by using statistical language model information (Church et al.1991; Church and Mercer 1993; Gale, Church, and Yarowsky 1992; Liddy and Paik 1992).
C92-2070 J93-1001
With an arbitrarily chosen standard test set, statistical language models can be compared (Brown, Della Pietra, Mercer, Della Pietra, and Lai 1992).
J92-1002 J92-4003
The systems described in Brown, Della Pietra, DeSouza, Lai, and Mercer (1992) and Brill and Marcus (1992) both provide examples of bottom-up, merge-based classification systems; a version of such a system was chosen to be implemented and tested against our algorithm, using the same input data.
J92-1002 J92-4003
Dagan, Markus, and Markovitch (1993) claim that word-classification systems of this type may lead to substantial information loss when compared to similarity methods (Dagan, Pereira, and Lee 1994; Essen and Steinbiss 1992).
P93-1022 P94-1038
In Brill et al.(1990), another automatic word-classification algorithm was developed and trained using the Brown corpus; they report success at partitioning words into word classes.
H90-1055
In order to make these improvements, we need access to word-class information (Pos information \[Johansson et al.1986; Black, Garside, and Leech 1993\] or semantic information \[Beckwith et al.1991\]), which is usually obtained in three main ways: Firstly, we can use corpora that have been manually tagged by linguistically informed experts (Derouault and Merialdo 1986).
P93-1005
Illustrative clusterings of this type can also be found in Pereira, Tishby, and Lee (1993), Brown, Della Pietra, Mercer, Della Pietra, and Lai (1992), Kneser and Ney (1993), and Brill et al.(1990), among others.
H90-1055 J92-1002 J92-4003 P93-1024
This criterion is the one used by Brown, Della Pietra, DeSouza, Lai, and Mercer (1992); Kneser and Ney (1993) show how it is equivalent to maximizing the bi-Pos-language model probability.
J92-1002 J92-4003
In many word-classification systems, the hierarchy is not explicitly represented and further processing, often by standard statistical clustering techniques, is required; see, for example, Elman (1990), Schtitze (1993), Brill et al.(1990), Finch and Chater (1994), Hughes and Atwell (1994), and Pereira and Tishby (1992).
H90-1055
Other versions of the top-down approach are used by Pereira and Tishby (1992) and Kneser and Ney (1993) to classify words; top-down procedures are also used in other areas (Kirkpatrick, Gelatt, and Vecchi 1983).
P93-1024
Indirect linguistic evaluation examines the utility of the derived classes in solving various linguistic problems: pronoun reference (Elman 1990; Fisher and Riloff 238 McMahon and Smith Improving Statistical Language Models 1992), agreement, word-sense disambiguation (Liddy and Paik 1992; Gale, Church, and Yarowsky 1992; Yarowsky 1992; Pereira, Tishby, and Lee 1993) and resolution of anaphoric reference (Burger and Connolly 1992).
C92-2070 J93-1001 P93-1024
Secondly, we can construct automatic part-ofspeech taggers and process untagged corpora (Kupiec 1992; Black, Garside, and Leech 1993); this method boasts a high degree of accuracy, although often the construction of the automatic tagger involves a bootstrapping process based on a core corpus which has been manually tagged (Church 1988).
A88-1019 P93-1005
The results described in Brown, Della Pietra, DeSouza, Lai, and Mercer (1992) are based on a training set two orders of magnitude greater than the one used in the above experiment.
J92-1002 J92-4003
We note that our 7.1% improvement is larger than that obtained by Brown, Della Pietra, DeSouza, Lai, and Mercer (1992), who report a 3.3% improvement.
J92-1002 J92-4003
