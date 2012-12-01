In (Cafarella et al., 2005), manually-prepared extraction rules are applied to a collection of 60 million Web documents to extract entities of types Company and Country, as well as facts of type Person-CeoOf-Company and City-CapitalOf-Country.
H05-1071
As a more realistic compromise over overly-cautious acquisition, the baseline run retains as many of the top candidate facts as the size of the current seed, whereas (Thelen and Riloff, 2002) only add the top five candidate facts to the seed set after each iteration.
W02-1028
Previous literature quasi-unanimously assesses the quality of each candidate fact based on the number and quality of the patterns that extract the candidate fact (more is better); and the number of seed facts extracted by the same patterns (again, more is better) (Agichtein and Gravano, 2000; Thelen and Riloff, 2002; Lita and Carbonell, 2004).
W02-1028
Whereas previous studies assume clean text collections such as news corpora (Thelen and Riloff, 2002; Agichtein and Gravano, 2000; Hasegawa et al., 2004), the validation is essential for low-quality sets of candidate facts collected from noisy Web documents.
P04-1053 W02-1028
As such, the resulting metric for evaluating recall used in (Cafarella et al., 2005) is somewhat similar to, though more relaxed than, the recall score over the ∩Gold set introduced in the previous section.
H05-1071
(Cafarella et al., 2005)).
H05-1071
Furthermore, the finer-grained ranking induced by similarities is necessary in fast-growth iterative acquisition, whereas previously proposed ranking criteria (Thelen and Riloff, 2002; Lita and Carbonell, 2004) are implicitly designed for slow growth of the seed set.
W02-1028
The textual portion of the documents is cleaned of Html, tokenized, split into sentences and partof-speech tagged using the TnT tagger (Brants, 2000).
A00-1031
Previous scoring functions were implicitly designed for cautious acquisition strategies (Collins and Singer, 1999), which expand the seed set very slowly across consecutive iterations.
W99-0613
Traditionally, the acquisition of contextual extraction patterns requires hundreds or thousands of consecutive iterations over the entire text collection (Lita and Carbonell, 2004), often using relatively expensive or restrictive tools such as shallow syntactic parsers (Riloff and Jones, 1999; Thelen and Riloff, 2002) or named entity recognizers (Agichtein and Gravano, 2000).
W02-1028
To our knowledge, the growth ratio and the number of extracted facts are several orders of magnitude higher than in any of the previous studies on fact extraction based on either hand-written extraction rules (Cafarella et al., 2005), or bootstrapping for relation and information extraction (Agichtein and Gravano, 2000; Lita and Carbonell, 2004).
H05-1071
Many methods have been proposed to compute distributional similarity between words, e.g., (Hindle, 1990), (Pereira et al., 1993), (Grefenstette, 1994) and (Lin, 1998).
P90-1034 P93-1024 P98-2127
The extraction of large sets of candidate facts opens the possibility of fast-growth iterative extraction, as opposed to the de-facto strategy of conservatively growing the seed set by as few as five items (Thelen and Riloff, 2002) after each iteration.
W02-1028
Pattern generalization is disabled, and the ranking of patterns and facts follows strictly the criteria and scoring functions from (Thelen and Riloff, 2002), which are also used in slightly different form in (Lita and Carbonell, 2004) and (Agichtein and Gravano, 2000).
W02-1028
To our knowledge, the only previous study that embeds similarities into the acquisition of extraction patterns is (Stevenson and Greenwood, 2005).
P05-1047
In contrast, the idea of bootstrapping for relation and information extraction was first proposed in (Riloff and Jones, 1999), and successfully applied to the construction of semantic lexicons (Thelen and Riloff, 2002), named entity recognition (Collins and Singer, 1999), extraction of binary relations (Agichtein and Gravano, 2000), and acquisition of structured data for tasks such as Question Answering (Lita and Carbonell, 2004; Fleischman et al., 2003).
P03-1001 W02-1028 W99-0613
The classes of words are computed on the fly over all sequences of terms in the extracted patterns, on top of a large set of pairwise similarities among words (Lin, 1998) extracted in advance from around 50 million news articles indexed by the Google search engine over three years.
P98-2127
