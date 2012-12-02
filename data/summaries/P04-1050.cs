Poesio et al.(2004) point out that there are many definitions of parameters such as “utterance”, “ranking” or “realisation”, and that the setting of these parameters greatly affects the predictions of the theory;1 however, they found violations of the Centering constraints with any way of setting the parameters (for instance, at least 25% of utterances have no CB under any such setting), so that the questions addressed by our work arise for all other settings as well.
J04-3003
The first distinguishing feature is that we assume a search-based approach to text structuring (Mellish et al., 1998; Kibble and Power, 2000; Karamanis and Manurung, 2002) in which many candidate orderings of clauses are evaluated according to scores assigned by a given metric, and the best-scoring ordering among the candidate solutions is chosen.
W00-1411 W98-1411
Poesio et al.(2004) found that nocbs account for more than 50% of the atomic facts the algorithm has to structure, i.e., we are assuming that CFs are arguments of such facts; including indirectly realized entities in CF lists would violate this assumption.
J04-3003
This definition of utterance is not optimal from the point of view of minimizing Centering violations (Poesio et al., 2004), but in this way most utterances are the realization of a single proposition; i.e., the impact of aggregation is greatly reduced.
J04-3003
According to Centering Theory (Grosz et al., 1995; Walker et al., 1998a), an important factor for the felicity of (1) is its entity coherence: the way centers (discourse entities), such as the referent of the NPs “144” in clause (a) and “its” in clause (b), are introduced and discussed in subsequent clauses.
J95-2003
(However, these notions might still be appropriate for other tasks, such as anaphora resolution.) 6 Discussion: the performance of M.NOCB We already saw that Poesio et al.(2004) found that the majority of the recorded transitions in the configuration of Centering used in this study are nocbs.
J04-3003
This is the second research question that this paper addresses, building upon previous work on corpus-based evaluations of Centering, and particularly the methods used by Poesio et al.(2004). We use the gnome corpus (Poesio et al., 2004) as the domain of our experiments because it is reliably annotated with features relevant to Centering and contains the genre that we are mainly interested in.
J04-3003
The ranking of the CFs other than the CP is defined according to the following preference on their gf (Brennan et al., 1987): obj>iobj>other.
P87-1022
M.KP sums up the nocbs and the violations of cheapness, coherence and salience, preferring the ordering with the lowest total cost (Kibble and Power, 2000).
W00-1411
Text (1), from the gnome corpus (Poesio et al., 2004), is an example of short human-authored text from this genre: (1) (a) 144 is a torc.
J04-3003
The second column of Table 1 shows how the utterances in example (1) are automatically translated by the scripts developed by Poesio et al.(2004) into a 1For example, one could equate “utterance” with sentence (Strube and Hahn, 1999; Miltsakaki, 2002), use indirect realisation for the computation of the CF list (Grosz et al., 1995), rank the CFs according to their information status (Strube and Hahn, 1999), etc.
J02-3003 J04-3003 J95-2003 J99-3001
However, how successful Centering’s constraints are on their own in generating a felicitous text structure is an open question, already raised by the seminal papers of the theory (Brennan et al., 1987; Grosz et al., 1995).
J95-2003 P87-1022
When CFn and CFn−1 do not have any centers in common, we compute the nocb transition (Kibble and Power, 2000) (Poesio et al’s null transition) for Un (e.g., utterance (d) in Table 1).5 4In accordance with Centering, no CB is computed for (a), the first utterance in the sequence.
W00-1411
In accordance with recent work in the emerging field of text-to-text generation (Barzilay et al., 2002; Lapata, 2003), we assume that the input to text structuring is a set of clauses.
P03-1069
CF lists, CPs and CBs According to Grosz et al.(1995), each “utterance” in a discourse is assigned a list of forward looking centers (CF list) each of which is “realised” by at least one NP in the utterance.
J95-2003
Poesio et al.(2004) showed that hypothesizing indirect realization eliminates many violations of entity continuity, the part of Constraint 1 that rules out nocb transitions.
J04-3003
Similarly, we use grammatical function (gf) combined with linear order within the unit (what Poesio et al.(2004) call gftherelin) for CF ranking.
J04-3003
However, in this work we are treating CF lists as an abstract representation Following again the terminology in Kibble and Power (2000), we call the requirement that CBn be the same as CBn−1 the principle of coherence and the requirement that CBn be the same as CPn the principle of salience.
W00-1411
This is the conclusion arrived at by Poesio et al.(2004) and those text structuring practitioners who use notions derived from Centering in combination with other coherence constraints in the definitions of their metrics.
J04-3003
Finally, the scripts determine whether CBn is the same as CPn−1, known as the principle of cheapness (Strube and Hahn, 1999).
J99-3001
the coherence of a corpus text according to Centering In this section we briefly introduce Centering, as well as the methodology developed in Poesio et al.(2004) to evaluate the coherence of a text according to Centering.
J04-3003
More generally, a significant percentage of nocbs (at least 20%) and other “dispreferred” transitions was found with all parameter configurations tested by Poesio et al.(2004) and indeed by all previous corpus-based evaluations of Centering such as Passoneau (1998), Di Eugenio (1998), Strube and Hahn (1999) among others.
J04-3003 J99-3001
Each of these principles can be satisfied or violated while their various combinations give rise to the standard transitions of Centering shown in Table 2; Poesio et al’s scripts compute these violations.6 We also make note of the preference between these transitions, known as Centering’s Rule 2 (Brennan et al., 1987): continue is preferred to retain, which is preferred to smoothshift, which is preferred to rough-shift.
P87-1022
These studies, however, do not investigate the question that is most important from the text structuring perspective adopted in this paper: whether there would be alternative ways of structuring the text that would result in fewer violations of Centering’s constraints (Kibble, 2001).
J01-4007
These results led Poesio et al.(2004) to the conclusion that the entity coherence as formalized in Centering should be supplemented with an account of other coherence inducing factors to explain what makes texts coherent.
J04-3003
