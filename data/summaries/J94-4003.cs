One such property is the use of deep, or canonical, relations, as was already identified by Grishman, Hirschman, and Nhan (1986).
J86-3002
79). This view is reflected also in their elaborate method for target word selection (Brown et al.1991), in which better estimates of translation probabilities are achieved as a result of word sense disambiguation.
P91-1034
It is interesting to compare our method with some aspects of the statistical machine translation system of Brown et al.(1990). As mentioned in the introduction, this system also incorporates target language statistics in the translation process.
J90-2002
We cite also the results of a later experiment (Dagan, Marcus, and Markovitch 1993) that tested a weaker variant of our method on texts in the computer domain, achieving a precision of 85%.
P93-1022 W93-0301
A promising approach may be to use aligned bilingual corpora, especially for augmenting existing lexicons with domain-specific terminology (Brown et al.1993; Dagan, Church, and Gale 1993).
H93-1039 P93-1022 W93-0301
Gale, Church, and Yarowsky (1992a) have also exploited this resource for achieving large amounts of testing and training materials.
C92-2070
These include a Bayesian classifier (Gale, Church, and Yarowsky 1993) and a distance 589 Computational Linguistics Volume 20, Number 4 metric between vectors (Schiitze 1993), both inspired from methods in information retrieval; the use of the flip-flop algorithm for ordering possible informants about the preferred sense, trying to maximize the mutual information between the informant and the ambiguous word (Brown et al.1991); and the use of confidence intervals to establish the degree of confidence in a certain preference, combined with a constraint propagation algorithm (the current paper).
P91-1034
Brown et al.(1991) make even weaker approximations, using only a stochastic part of speech tagger, and defining relations such as "the first verb to the right" or "the first noun to the left".
P91-1034
If a parser for the target language corpus is not available, it is possible to approximate the statistics using word co-occurrence in a window, as was demonstrated by a variant of our method (Dagan, Marcus, and Markovitch 1993) (see Section 5.1).
P93-1022 W93-0301
Gale, William; Church, Kenneth; and Yarowsky, David (1992b).
C92-2070
Such syntactic rules that allow us to resolve some of the ambiguities may be encoded in the lexicon (e.g., Golan, Lappin, and Rimon 1988).
C88-1042
Gale, William; Church, Kenneth; and Yarowsky, David (1992a).
C92-2070
To resolve such ambiguities, it may be useful to consider also co-occurrences of the ambiguous word with other words in the broader context (e.g., Gale, Church, and Yarowsky 1993; Yarkowsky 1992).
C92-2070
Substantial application of semantic or pragmatic knowledge about the word and its context requires compiling huge amounts of knowledge, the usefulness of which for practical applications in broad domains has not yet been proven (e.g., Lenat et al.1990; Nirenburg et al.1988; Chodorow, Byrd, and Heidron 1985).
P85-1037
The use of such relations (mainly relations between verbs or nouns and their arguments and modifiers) for various purposes has received growing attention in recent research (Church and Hanks 1990; Zernik and Jacobs 1990; Hindle 1990; Smadja 1993).
C90-1005 J90-1003 J93-1007 P90-1034
His results may be improved if more sophisticated methods and larger corpora are used to establish similarity between words (such as in Hindle 1990).
P90-1034
Yarowsky, David (1992).
C92-2070
• Combining several informants: The methods described by Brown et al.(1991) and in the current paper combine several informants (i.e., statistics about several context words) by choosing the informant that seems most indicative for the selection.
P91-1034
Erroneously, the preliminary publication of our method (Dagan, Itai, and Schwall 1991) was cited several times as requiring a parallel bilingual corpus, 565 Computational Linguistics Volume 20, Number 4 2.
P91-1017
The major difference between the TWS method, as presented in this paper, and the variant described by Dagan, Marcus, and Markovitch (1993), which we term TWS ~, is that the latter does not use any parsing for collecting the statistics from the corpus.
P93-1022 W93-0301
also Gale, Church, and Yarowsky 1992b (pp.
C92-2070
It seems, however, that Brown et al.expect that target word selection would be determined mainly by translation probabilities (the second factor in the above term), which should be derived from a bilingual corpus (Brown et al.1990, p.
J90-2002
Section 5 presents and analyzes the results of the experiment and cites additional results (Dagan, Marcus, and Markovitch 1993).
P93-1022 W93-0301
Brown et al.(1991) were concerned with sense disambiguation for machine translation.
P91-1034
Yarowsky (1992) proposes a method that completely avoids manual tagging of the training corpus.
C92-2070
A second type of information is provided by words that occur in the global context of the ambiguous word (Gale, Church, and Yarowsky 1992b, 1993; Yarowsky 1992; Sch6tze 1992).
C92-2070
Such comparative evaluations are not available yet, not even for systems that incorporate several types of data (e.g., McRoy 1992).
J92-1001
More specifically, two recent works have suggested using statistical data on lexical relations for resolving ambiguity of prepositional phrase attachment (Hindle and Rooth 1991) and pronoun references (Dagan and Itai 1990, 1991).
P90-1034 P91-1017 P91-1030
Gale proposes to use "pseudo-words" as another practical source of testing examples (Gale, Church, and Yarowsky 1992b) (equivalently, Schfitze \[1992\] uses "artificial ambiguous words").
C92-2070
Dagan, Ido, and Itai, Alon (1991).
P91-1017
Gale et al.and Yarowsky use words that appear within 50 words in each 14 The reader is referred to some of these recent papers for thorough surveys of work on sense disambiguation (Hearst 1991; Gale, Church, and Yarowsky 1992a; Yarowsky 1992).
C92-2070
58-59), and Sch~itze, 1992, 1993, for methods of reducing the number of parameters when using global contexts and Dagan, Marcus, and Markovitch 1993, for increasing the applicability of the use of local context, in cases in which there is no direct statistical evidence.
P93-1022 W93-0301
Church, Kenneth W., and Hanks, Patrick (1990).
J90-1003
A possible solution is to use an aligned bilingual corpus, as suggested by Sadler (1989), Brown et al.(1991), and Gale et al.(1992a). In such a corpus the occurrences of the relation 'young prospect' will be aligned to the corresponding occurrences of the Hebrew word tiqwa and will not be used when the Hebrew word sikkuy is involved.
P91-1034
Smadja, Frank (1993).
J93-1007
For example, it was used for acquiring statistics for disambiguating prepositional phrase attachments, counting ambiguous occurrences of prepositional phrases as representing both noun-pp and verb-pp constructs (Hindle and Rooth 1991).
P91-1030
In particular, an enhancement of our disambiguation method, using similarity-based estimation (Dagan, Marcus, and Markovitch 1993), was evaluated recently.
P93-1022 W93-0301
Dagan, Ido; Marcus, Shaul; and Markovitch, Shaul (1993).
P93-1022 W93-0301
Brown, Peter; Della Pietra, Stephen; Della Pietra, Vincent; and Mercer, Robert (1993).
H93-1039
Golan, Igal; Lappin, Shalom; and Rimon, Mori (1988).
C88-1042
To a limited extent, this view is shared with the statistical machine translation system of Brown et al.(1990), which employs a target language n-gram model (see Section 8 for a comparison with this system).
J90-2002
Dagan, Ido; Itai, Alon; and Schwall, Ulrike (1991).
P91-1017
(~) 1994 Association for Computational Linguistics Computational Linguistics Volume 20, Number 4 knowledge can be found in the use of statistical data on the occurrence of lexical relations in large corpora (e.g., Grishman, Hirschman, and Nhan 1986).
J86-3002
Statistics on co-occurrence of words in a local context were used recently for monolingual word sense disambiguation (Gale, Church, and Yarowsky 1992b, 1993; Sch6tze 1992, 1993) (see Section 7 for more details and Church and Hanks 1990; Smadja 1993, for other applications of these statistics).
C92-2070 J90-1003 J93-1007
Finally, Dagan et al.(1993) (see Section 5.1) assume full parsing at the disambiguation phase, but no preprocessing at the training phase, in which a higher level of noise can be accommodated.
P93-1022 W93-0301
similar observation underlies the use of parallel bilingual corpora for sense disambiguation (Brown et al.1991; Gale, Church, and Yarowsky 1992).
C92-2070 P91-1034
In one of our examples, for instance, none of the alternative relations, 'an investigator of corruption' (the correct one) or 'researcher of corruption' (the incorrect one), 11 It should be mentioned that the work of Dagan, Marcus, and Markovitch (1993) includes further results, evaluating an enhancement of the TWS method using their similarity-based estimation method.
P93-1022 W93-0301
Gale, Church, and Yarowsky (1992b, pp.
C92-2070
Dagan, Ido; Church, Kenneth; and Gale, William (1993).
P93-1022 W93-0301
This variant was developed for evaluating a method that estimates the probability of word combinations which do not occur in the training corpus (Dagan, Marcus, and Markovitch 1993).
P93-1022 W93-0301
