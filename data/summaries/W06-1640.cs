This variety of classifier and training data settings was motivated by reported differences in performance of coreference resolution approaches w.r.t. these variations (Ng and Cardie, 2002).
P02-1014
Rule Learner We develop a novel method for partially supervised clustering, which is motivated by the success of a rule learner (RIPPER) for coreference resolution (Ng and Cardie, 2002).
P02-1014
Stoyanov et al.(2005), Riloff et al.(2005)). To date, research in the area (see Related Work section) has focused on the problem of extracting sentiment both at the document level (coarse-grained sentiment information), and at the level of sentences, clauses, or individual expressions (finegrained sentiment information).
H05-1116
In contrast, we follow recent approaches to supervised clustering that propose ways to learn the distance measure in the context of the clustering decisions (Li and Roth, 2005; Finley and Joachims, 2005; McCallum and Wellner, 2003).
W05-0609
In contrast to the opinion extracts produced by Pang and Lee (2004), our summaries are not text extracts, but rather explicitly identify and 337 characterize the relations between opinions and their sources.
P04-1035
Ng and Cardie (2002), Morton (2000)).
P00-1023 P02-1014
Our general approach to source coreference resolution is inspired by the state-of-the-art performance of one such approach to coreference resolution, which relies on a rule learner and single-link clustering as described in Ng and Cardie (2002).
P02-1014
Bethard et al.(2004), Choi et al.(2005), Kim and Hovy (2005)) can be extracted automatically, little has been done to create opinion summaries, where opinions from the same source/target are combined, statistics are computed for each source/target and multiple opinions from the same source to the same target are aggregated.
H05-1045
B3). Other efforts in the area of supervised clustering (Finley and Joachims, 2005; Li and Roth, 2005) have suggested ways to learn distance measures that can optimize directly for a desired performance measure.
W05-0609
In particular, we use the aforementioned algorithm proposed by Ng and Cardie (2002), which combines a pairwise NP coreference classifier with single-link clustering.
P02-1014
We use the B3 (Bagga and Baldwin, 1998) evaluation measure as well as precision, recall, and F1 measured on the (positive) pairwise decisions.
P98-1012
More details on the different parameter settings and instance selection algorithms as well as trends in the performance of different settings can be found in Stoyanov and Cardie (2006).
W06-0302
We use the features introduced by Ng and Cardie (2002) for the task of coreference resolution.
P02-1014
More details about why heuristics are needed and the process used to map sources to NPs can be found in Stoyanov and Cardie (2006).
W06-0302
Das and Chen (2001), Pang et al.(2002), Turney (2002), Dave et al.(2003)). Other research has concentrated on analyzing fine-grained opinions at, or below, the sentence level.
P02-1053 W02-1011
Dave et al.(2003), Riloff and Wiebe (2003), Bethard et al.(2004), Wilson et al.(2004), Yu and Hatzivassiloglou (2003), Choi et al.(2005), Kim and Hovy (2005), Wiebe and Riloff (2005)).
H05-1045 W03-1014 W03-1017
We instead follow the framework of supervised clustering (Finley and Joachims, 2005; Li and Roth, 2005) and consider each document as a training example.
W05-0609
pronouns link to their single antecedent) and has exhibited good performance for coreference resolution (Ng and Cardie, 2002).
P02-1014
Riloff and Wiebe (2003), Bethard et al.(2004), Wiebe and Riloff (2005)) as well as their sources (e.g.
W03-1014
Morton (2000), Ng and Cardie (2002), Iida et al.(2003), McCallum and Wellner (2003)).
P00-1023 P02-1014
