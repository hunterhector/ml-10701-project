This approach was shown to perform well on real-world natural language problems (Collins and Singer, 1999).
W99-0613
Previous studies called the class of algorithms illustrated in Figure 2 “cautious” or “sequential” because in each iteration they acquire 1 or a small set of rules (Abney, 2004; Collins and Singer, 1999).
J04-3004 W99-0613
To our knowledge, this system, or a variation of it, is the current state-of-the-art in pattern acquisition (Riloff, 1996; Yangarber et al., 2000; Yangarber, 2003; Stevenson and Greenwood, 2005).
C00-2136 P03-1044 P05-1047
For this reason, much of the following work on pattern acquisition has used this approach as a de facto evaluation standard (Yangarber, 2003; Stevenson and Greenwood, 2005).
P03-1044 P05-1047
Criterion 2: Collins This criterion was used in a lightly-supervised NE recognizer (Collins and Singer, 1999).
W99-0613
Criterion 1: Riloff This selection criterion was developed specifically for the pattern acquisition task (Riloff, 1996) and has been used in several other pattern acquisition systems (Yangarber et al., 2000; Yangarber, 2003; Stevenson and Greenwood, 2005).
C00-2136 P03-1044 P05-1047
Similarlyto(Collins and Singer, 1999; Yarowsky, 1995), we define the strength of a pattern p in a category y as the precision of p in the set of documents labeled with category y, estimated using Laplace smoothing: strength(p,y) = count(p,y) + epsilon1count(p) + kepsilon1 (3) where count(p,y) is the number of documents labeled y containing pattern p, count(p) is the overall number of labeled documents containing p, and k is the number of domains.
P95-1026 W99-0613
Although a rich literature covers bootstrapping methods applied to natural language problems (Yarowsky, 1995; Riloff, 1996; Collins and Singer, 1999; Yangarber et al., 2000; Yangarber, 2003; Abney, 2004) several questions remain unanswered when these methods are applied to syntactic or semantic pattern acquisition.
C00-2136 J04-3004 P03-1044 P95-1026 W99-0613
Theorem 5 in (Abney, 2002) provides a theoretical explanation for these results: if certain independence conditions between the classifier rules are satisfied and the precision of each rule is larger than a threshold T, then the precision of the final classifier is larger than T.
P02-1046
Wehavechosenthisevaluationstrategybecause this indirect approach was shown to correlate well withadirectevaluation,wherethelearnedpatterns were used to customize an IE system (Yangarber et al., 2000).
C00-2136
Domain-specific patterns are either handcrafted or acquired automatically (Riloff, 1996; Yangarber et al., 2000; Yangarber, 2003; Stevenson and Greenwood, 2005).
C00-2136 P03-1044 P05-1047
Abney. 2002.
P02-1046
(6) Similarly to (Collins and Singer, 1999) we used T = 0.95 for all experiments reported here.
W99-0613
Several approaches have been proposed in the context of word sense disambiguation (Yarowsky, 1995), named entity (NE) classification (Collins and Singer, 1999), patternacquisitionforIE(Riloff,1996; Yangarber, 2003), or dimensionality reduction for text categorization (TC) (Yang and Pedersen, 1997).
P03-1044 P95-1026 W99-0613
Thispaperfocusesontheframeworkintroduced in Figure 2 for two reasons: (a) “cautious” al50 gorithms were shown to perform best for several NLP problems (including acquisition of IE patterns), and (b) it has nice theoretical properties: Abney (2004) showed that, regardless of the selection procedure, “sequential” bootstrapping algorithms converge to a local minimum of K, where K is an upper bound of the negative log likelihood of the data.
J04-3004
Another point where acquisition algorithms differistheinitializationprocedure: somestartwitha small number of hand-labeled documents (Riloff, 1996), as illustrated in Figure 2, while others start with a set of seed rules (Yangarber et al., 2000; Yangarber, 2003).
C00-2136 P03-1044
