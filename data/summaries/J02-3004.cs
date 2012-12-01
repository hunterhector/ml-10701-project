With the exception of Wu (1993) and Lauer (1995), who use probabilistic models for compound noun interpretation (see Section 7 for details), most algorithms rely on hand-crafted knowledge bases or dictionaries that contain detailed semantic information for each noun; a sequence of rules exploit a knowledge base to choose the correct interpretation for a given compound (Finin 1980; McDonald 1982; Leonard 1984; Vanderwende 1994).
C94-2125
We estimate the frequency of an unseen verb-argument tuple by taking into account the similar w 1 s and the contexts in which they occur (Grishman and Sterling 1994): f s (w 1, rel, w 2 )= summationdisplay w prime 1 sim(w 1, w prime 1 )f(w prime 1, rel, w 2 )(21) where sim(w 1, w prime 1 ) is a function of the similarity between w 1 and w prime 1 . In our experiments the confusion probability P C (w 1 | w prime 1 ) and the Jensen-Shannon divergence W J (w 1, w 1 prime ) were substituted for sim(w 1, w prime 1 ).
C94-2119
This finding is not entirely unexpected, considering that compounds are typically used as a text compression device (Marsh 1984), that is, to pack meaning into a minimal amount of linguistic structure.
P84-1108
The same task is used by Lee and Pereira (1999) in a detailed comparison between distributional clustering and distance-weighted averaging that demonstrates that the two methods yield comparable results.
P99-1004 P99-1005
satellite observation subj|obj Besides Levi (1978), a fair number of researchers (Warren 1978; Finin 1980; Isabelle 1984; Leonard 1984) agree that there is a limited number of regularly recurring relations between a compound head and its modifier.
P84-1109
In the following we describe these two similarity measures and show how they can be used to re-create the frequencies for unseen verb-argument tuples (for a more detailed description see Dagan, Lee, and Pereira (1999)).
P99-1004 P99-1005
Copestake and Lascarides (1997) and Lascarides and Copestake (1998) make the same observation for a variety of constructions such as compound nouns, adjective-noun combinations and verb-argument relations.
P97-1018
The task of finding the right class for representing the argument of a given predicate is a research issue on its own (Clark and Weir 2001; Li and Abe 1998; Carroll and McCarthy 2000), and a detailed comparison between different methods for accomplishing this task is beyond the scope of the present study.
J98-2002 N01-1013
Dagan, Lee, and Pereira (1999) use perplexity to compare back-off smoothing against distance-weighted averaging methods within the context of language modeling for speech recognition and show that the latter outperform the former.
P99-1004 P99-1005
3.1 Back-Off Smoothing Back-off n-gram models were initially proposed by Katz (1987) for speech recognition but have also been successfully used to disambiguate the attachment site of structurally ambiguous prepositional phrases (Collins and Brooks 1995).
W95-0103
Despite the differences among them, most approaches require large amounts of hand-crafted knowledge, place emphasis on the recovery of relations other than nominalizations (see the examples in (1)), contain no quantitative evaluation (the exceptions are Leonard (1984), Vanderwende (1994), and Lauer (1995)), and generally assume that context dependence is either negligible or of little impact.
C94-2125
Several measures of distributional similarity have been proposed in the literature (Dagan, Lee, and Pereira 1999; Lee 1999).
P99-1004 P99-1005
We re-created the frequencies of unseen verb-argument pairs by experimenting with three types of smoothing techniques proposed in the literature: back-off smoothing (Katz 1987), class-based smoothing (Resnik 1993; Lauer 1995), and distanceweighted averaging (Grishman and Sterling 1994; Dagan, Lee, and Pereira 1999).
C94-2119 P99-1004 P99-1005
Although the use of classifiers has been widespread in studies concerning discourse segmentation (Passonneau and Litman 1997), the disambiguation of discourse cues (Siegel and McKeown 1994), the acquisition of lexical semantic classes (Merlo and Stevenson 1999; Siegel 1999), the automatic identification of user corrections in spoken dialogue systems (Hirschberg, Litman, and Swerts 2001), and word sense disambiguation (Pedersen 2001), the treatment of the interpretation of compound nouns as a classification task is, to our knowledge, novel.
E99-1007 J97-1005 N01-1011 N01-1027 P99-1015
A considerable amount of effort has gone into specifying the set of semantic relations that hold between a compound head and its modifier (Levi 1978; Warren 1978; Finin 1980; Isabelle 1984).
P84-1109
Furthermore, as Lee and Pereira’s (1999) results indicate that distributional clustering 365 Lapata The Disambiguation of Nominalizations and distance-weighted averaging obtain similar levels of performance, we restricted ourselves to the latter.
P99-1004 P99-1005
P(rel | n 1, n 2 )= f(n 1, rel, n 2 ) f(n 1, n 2 ) (6) Since we have a choice between two outcomes we will use a likelihood ratio to compare the two relation probabilities (Mosteller and Wallace 1964; Hindle and Rooth 1993).
J93-1005
Although the Kappa coefficient has a number of advantages over percentage agreement (e.g., it takes into account the expected chance interrater agreement; see Carletta (1996) for details), we also report percentage agreement as it allows us to compare straightforwardly the human performance and the automatic methods described below, whose performance will also be reported in terms of percentage agreement.
J96-2004
Instead, it is based on the assumption that if a word w prime 1 is similar to word w 1, then w prime 1 can provide information about the frequency of unseen word pairs involving w 1 (Dagan, Lee, and Pereira 1999).
P99-1004 P99-1005
Vanderwende (1994) further developed a rule-based algorithm that does not rely on a hand-crafted lexicon but extracts the required semantic information from an on-line dictionary instead.
C94-2125
The smoothing methods proposed in the literature (overviews are provided by Dagan, Lee, and Pereira (1999) and Lee (1999)) can be generally divided into three types: discounting (Katz 1987), class-based smoothing (Resnik 1993; Brown et al.1992; 364 Computational Linguistics Volume 28, Number 3 Pereira, Tishby, and Lee 1993), and distance-weighted averaging (Grishman and Sterling 1994; Dagan, Lee, and Pereira 1999).
C94-2119 J92-4003 P93-1024 P99-1004 P99-1005
The choice of these two measures was motivated by work described in Dagan, Lee, and Pereira (1999), in which the JensenShannon divergence outperforms related similarity measures (such as the confusion probability or the L 1 norm) on a pseudodisambiguation task that uses verb-object pairs.
P99-1004 P99-1005
Classes can be induced directly from the corpus using distributional clustering (Pereira, Tishby, and Lee 1993; Brown et al.1992; Lee and Pereira 1999) or taken from a manually crafted taxonomy (Resnik 1993).
J92-4003 P93-1024 P99-1004 P99-1005
The confusion probability has been used by several authors to smooth word co367 Lapata The Disambiguation of Nominalizations occurrence probabilities (Essen and Steinbiss 1992; Grishman and Sterling 1994) and shown to give promising performance.
C94-2119
Grishman and Sterling (1994) in particular employ the confusion probability to re-create the frequencies of verb-noun co-occurrences in which the noun is the object or the subject of the verb in question.
C94-2119
Because compounds can be used as a text compression device (Marsh 1984), it is plausible that pragmatic inference is required to supply the compound’s interpretation.
P84-1108
