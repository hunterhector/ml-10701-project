We also give the value of WindowDiff (WD), a variant of Pk proposed in (Pevzner and Hearst, 2002) that corrects some of its insufficiencies.
J02-1002
U00 is the system described in (Utiyama and Isahara, 2001), C99 the one proposed in (Choi, 2000) and LCseg is presented in (Galley et al., 2003).
A00-2004 P01-1064 P03-1071
(Purver et al., 2006) is closer to our work than (Blei and Moreno, 2001) because it does not require to build topic models from a corpus but as in our case, its results do not outperform LCseg (Galley et al., 2003) while its model is far more complex.
P03-1071 P06-1003
Most of them only rely on surface features of documents: word reiteration in (Hearst, 1994; Choi, 2000; Utiyama and Isahara, 2001; Galley et al., 2003) or discourse cues in (Passonneau and Litman, 1997; Galley et al., 2003).
A00-2004 J97-1005 P01-1064 P03-1071 P94-1002 W01-0514
This part of the Discourse Analysis field has received a constant interest since the initial work in this domain such as (Hearst, 1994).
P94-1002
In CWM (Choi et al., 2001), a variant of C99, each word of a sentence is replaced by its representation in a Latent Semantic Analysis (LSA) space.
W01-0514
In fact, the way we use relations between words is closer to (Jobbins and Evett, 1998), even if the relations in this work come from a network of co-occurrences or a thesaurus rather than from text topics.
P98-1100
This means probably that algorithms with good results on a corpus built as the Choi corpus will not necessarily have good results on “true” texts, which agrees with (Georgescul et al., 2006).
W06-1320
This resource was also used in (Morris and Hirst, 1991) where the similarity between discourse units was more indirectly evaluated through the lexical chains they share.
J91-1002
More recently, (Purver et al., 2006) has also proposed a method for unsupervised topic modeling to address both topic segmentation and identi486 fication.
P06-1003
To overcome these difficulties, some systems make use of domain-independent knowledge about lexical cohesion: a lexical network built from a dictionary in (Kozima, 1993); a thesaurus in (Morris and Hirst, 1991); a large set of lexical cooccurrences collected from a corpus in (Choi et al., 2001).
J91-1002 P93-1041 W01-0514
Since the work of Choi (Choi, 2000), the evaluation framework he proposed has become a kind of standard for the evaluation of topic segmentation algorithms.
A00-2004
Hearst. 1994.
P94-1002
This is done in our case by applying the Dice coefficient between the two sides of the focus window, following (Jobbins and Evett, 1998).
P98-1100
Text Topics for Segmentation 4.1 Topic segmentation using word reiteration As TextTiling, the topic segmentation method of Hearst (Hearst, 1994), the topic segmenter we propose, called F06, first evaluates the lexical cohesion of texts and then finds their topic shifts by identifying breaks in this cohesion.
P94-1002
This was done for instance in (Jobbins and Evett, 1998) by taking semantic relations from Roget’s Thesaurus.
P98-1100
Hybrid systems that combine the approaches we have presented were also developed and illustrated the interest of such a combination: (Jobbins and Evett, 1998) combined word recurrence, co-occurrences and a thesaurus; (Beeferman et al., 1999) relied on both lexical modeling and discourse cues; (Galley et al., 2003) made use of word reiteration through lexical chains and discourse cues.
P03-1071 P98-1100
The last part of our algorithm is mainly taken from the LCseg system (Galley et al., 2003) and is divided into three steps: • computation of a score evaluating the probability of each minimum of the cohesion graph to be a topic shift; • removal of segments with a too small size; • selection of topic shifts.
P03-1071
This network could also be used more directly for topic segmentation as in (Jobbins and Evett, 1998).
P98-1100
More precisely, if Wl refers to the vocabulary of the left side of the focus window and Wr refers to the vocabulary of its right side, the cohesion in the window at position x is given by: LCrec(x) = 2 · card(Wl ∩ Wr)card(W l) + card(Wr) (1) This measure was adopted instead of the Cosine measure used in TextTiling because its definition in terms of sets makes it easier to extend for taking into account other types of relations, as in (Jobbins and Evett, 1998).
P98-1100
TextTiling* is a variant of TextTiling in which the final identification of topic shifts is taken from (Galley et al., 2003).
P03-1071
