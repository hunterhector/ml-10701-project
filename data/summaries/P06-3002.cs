Partitioning 2: Medium and low frequency words As noted in (Dunning, 1993), log-likelihood statistics are able to capture word bi-gram regularities.
J93-1003
Word cluster ID cluster members (size) I 166 I (1) saw 2 past tense verbs (3818) the 73 a, an, the (3) man 1 nouns (17418) with 13 prepositions (143) a 73 a, an, the (3) saw 1 nouns (17418) . 116 . ! ? (3) Table 4: Tagging example We compare our results to (Freitag, 2004), as most other works use different evaluation techniques that are only indirectly measuring what we try to optimize here.
C04-1052
Freitag (2004) does not sum up the contexts of each word in a context vector, but the most frequent instances of four-word windows are used in a co-clustering algorithm.
C04-1052
An extension to this generic scheme is presented in (Clark, 2003), where morphological 7 information is used for determining the word class of rare words.
E03-1009
Unfortunately, (Freitag 2004) does not provide a total PP score for his 200 tags.
C04-1052
Biemann. 2006.
W06-3812
Dunning. 1993.
J93-1003
Freitag. 2004.
C04-1052
methodology We adopt the methodology of (Freitag 2004) and measure cluster-conditional tag perplexity PP as the average amount of uncertainty to predict the tags of a POS-tagged corpus, given the tagging with classes from the unsupervised method.
C04-1052
(van Dongen, 2000; Biemann 2006), find the number of clusters automatically 1. Further, outliers are handled naturally in that framework, as they are represented as singleton nodes (without edges) and can be excluded from the clustering.
W06-3812
For assigning classes, we use the Chinese Whispers (CW) graph-clustering algorithm, which has been proven useful in NLP applications as described in (Biemann 2006).
W06-3812
Morphological Extension Morphologically motivated add-ons are used e.g. in (Clark, 2003) and (Freitag 2004) to guess a more appropriate category distribution based on a word’s suffix or its capitalization for OOV words.
C04-1052 E03-1009
Clark. 2003.
E03-1009
