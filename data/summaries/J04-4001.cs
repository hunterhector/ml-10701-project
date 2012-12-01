Kibble (1999) dubbed these principles cohe404 Computational Linguistics Volume 30, Number 4 Table 1 Centering transitions.
W99-0109
Our exposition will refer to an implemented document generation system, Iconoclast, which uses the technique of constraint satisfaction (van Hentenryck 1989; Power 2000; Power, Scott, and Bouayad-Agha 2003) with CT principles implemented among a set of soft constraints.
C00-2093 J03-2003
The methodology is more fully described by Power, Scott, and Bouayad-Agha (2003).
J03-2003
Karamanis (2001), Kibble (2001), and Beaver (2004), have argued for a ranking of the centering principles as opposed to weighting, and indeed Beaver provides a unified formulation of the centering rules and constraints as a ranked set of OT constraints.
J01-4007
Consequently, the text planner appears to rely on decisions made at the sentenceplanning level, which is incompatible with the fact that “pipelined systems cannot perform general search over a decision space which includes decisions made in more than one module” (Reiter 2000, page 252).
J00-2005
Strube and Hahn claim that the cheapness principle is motivated by the existence of Retain-Shift patterns, which are evidently a common means of introducing a new topic (see also Brennan, Friedman, and Pollard 1987 [henceforth BFP]).
P87-1022
We regard Cheng’s (2000) work on the interaction of centering preferences and aggregation in text planning as complementary to our enterprise.
A00-3001
It is not our primary aim in this short article to provide an empirical assessment of the claims of CT, for which we refer the reader to the relevant papers, such as 1 Callaway and Lester (2002) note that CT-based pronominalization algorithms “assume that the discourse tree was constructed with Centering theory in mind” (page 91); in our case this assumption is justified.
P02-1012
Previous algorithms for pronominalization such as those of McCoy and Strube (1999), Henschel, Cheng, and Poesio (2000), and Callaway and Lester (2002) have addressed the task of deciding whether to realize an entity as a pronoun on the basis of given factors such as its syntactic role and discourse history within a given text structure; what is essentially novel in our approach is that we treat referential coherence as a planning problem, on the assumption that obtaining a favorable ordering of clauses, and of arguments within clauses, is likely to increase opportunities for nonambiguous pronoun use.
A00-3001 C00-1045 J99-3001 P02-1012 W99-0108
versus Constraints Kibble (1999, 2001) argued for a decomposition of the canonical transition types into the principles of cohesion and salience, partly on the architectural grounds that this makes it easier to apply CT to the generation task, and partly on the empirical grounds that the preference ordering assumed by GJW is not strongly supported by corpus evidence and that transitions are better seen as epiphenomenal, emerging in a partial ordering from the interaction of more fundamental constraints.
J01-4007 W99-0109
This approach also means that Strube and Hahn’s (1999) principle of cheapness can be naturally incorporated as an additional constraint: This is a requirement that Cp(U n−1 )=Cb(U n ).
J99-3001
3. Generation Issues CT has developed primarily in the context of natural language interpretation, focussing on anaphora resolution (see, e.g., Brennan, Friedman, and Pollard 1987).
P87-1022
These are among the distinct tasks identified in Reiter’s “consensus architecture” for natural language generation (Reiter 1994): Text planning/content determination: deciding the content of a message and organizing the component propositions into a text structure (typically a tree) Sentence planning: aggregating propositions into clausal units and choosing lexical items corresponding to concepts in the knowledge base; this is the level at which the order of arguments and choice of referring expressions will be determined Linguistic realization: surface details such as agreement and orthography Reiter observed that these functions can often be identified with discrete modules in applied NLG systems and that a de facto standard had emerged in which these modules are organized in a pipeline such that data flows only in one direction and only between consecutive modules.
W94-0319
Veins theory (Cristea, Ide, and Romary 1998) provides a possible formalization of the intuition that some earlier propositions become inaccessible as a rhetorical boundary is crossed.
P98-1044
Mittal et al.(1998) apply what we term salience to sentence planning, with the goal of realizing the Cb as subject, though the text planner does not have a goal of attempting to maintain the same Cb.
J98-3004
Power, Scott, and Bouayad-Agha (2003) for detailed motivation of this concept of text structure as a level of representation distinct from both rhetorical structure and syntactic structure.
J03-2003
Constraint satisfaction search was applied by Marcu (1996, 1997) to the far harder task of constructing RST trees given a set of facts and a repertoire of rhetorical relations; Mellish et al.(1998) argue that this approach may not scale up to the generation of larger texts and propose an alternative using stochastic search.
W98-1411
Following a hierarchical criterion, the predecessor is the most accessible previous proposition, in the sense defined by Veins Theory (Cristea, Ide, and Romary, 1998).
P98-1044
Strube and Hahn (1999) take an intermediate position: In their formulation, pairs of transitions 〈〈U i, U j 〉, 〈U j, U k 〉〉 are preferred that are cheap, that is, Cp(U j )=Cb(U k ).
J99-3001
A possible future development is to supplement our CT-based text planner with a more sophisticated pronominalization algorithm as proposed by Henschel, Cheng, and Poesio (2000) or Callaway and Lester (2002).
A00-3001 C00-1045 P02-1012
Since Brennan, Friedman, and Pollard (1987), a ranking in terms of grammatical roles (or obliqueness) has become standard; for example: subject > direct object > indirect object > others.
P87-1022
These are issues which the well-known centering theory (CT) of Grosz, Joshi, and Weinstein (1995; henceforth GJW) is concerned with.
J95-2003
Combinations of these preferences provide the familiar canonical set of transitions shown in Table 1, ranked in the stipulated order of preference first set out as Rule 2 by Brennan, Friedman, and Pollard (1987) and adopted by Walker, Joshi, and Prince (1998b).
P87-1022
405 Kibble and Power Optimizing Referential Coherence 2.3 Utterance and Previous Utterance Two different approaches to the realization of “utterance” have become associated with the work of Kameyama (1998) and Suri, McCoy, and DeCristoforo (1999).
J99-2001 W99-0108
Stage 1 of the planning procedure is described in more detail by Power, Scott, and Bouayad-Agha (2003).
J03-2003
