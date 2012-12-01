For example, the method of Cowan et al.(2006) synchronizes elementary trees of a prescribed form to handle translation of clauses (verbs plus their arguments) essentially implementing a kind of STSG.
W06-1628
Successful experiments such as those of Chiang (2005) using synchronous context-free grammar are a good first start.4 2.3 Heritage of the construction principle We have argued that a formalism expressive enough to model the translation relation implicit in bilingual dictionaries must be based on relations over constructions, the primitive relations found in such bilingual dictionaries and founded by the Construction Principle.
P05-1033
Nesson et al.(2006) use synchronous treeinsertion grammar (STIG) (Schabes and Waters, 1995) rather than STAG for this very reason.
J95-4002
And again, we see this insight informing statistical machine translation systems, for instance, in the phrase-based approaches of Och (2003) and Koehn et al.(2003). These two principles, while true, do not exhaust the insights implicit in the structure of bilingual dictionaries.
N03-1017
The basic idea of using synchronous TAG for machine translation dates from the original definition (Shieber and Schabes, 1990), and has been pursued by several researchers (Abeille et al., 1990; Dras, 1999; Prigent, 1994; Palmer et al., 1999), but only recently in its probabilistic form (Nesson et al., 2006).
C90-3001 C90-3045 P99-1011
These tree pairs might be manually generated, automatically reconstructed from repurposed bilingual dictionaries, or automatically induced from aligned bilingual treebanks (Groves et al., 2004; Groves and Way, 2005) or even unannotated bilingual corpora (Chiang, 2005).
C04-1154 P05-1033 W05-0833
StuartM.ShieberandYvesSchabes. 1990.
C90-3045
Similarly, recent research is beginning to unify synchronous grammar formalisms and tree transducers (Shieber, 2004; Shieber, 2006).
E06-1048
Shieber. 2006.
E06-1048
MethodssuchasthoseofChiang(2005) have been proposed for further reducing the complexity of SCFG parsing; they may be applicable to STIG (and STAG) parsing as well.
P05-1033
The recognition problem for STAG, like that for synchronous context-free grammar (SCFG) is NP-hard (Satta and Peserico, 2005).
H05-1101
Systems based on word-to-word lexicons, such as the IBM systems (Brown et al., 1990; Brown et al., 1993), incorporate further devices that allow reordering of words (a “distortion model”) and ranking of alternatives (a monolingual language model).
J90-2002 J93-2003
On the positive side, recent work exploring the automaticbinarizationofsynchronousgrammars(Zhang et al., 2006) has indicated that non-binarizable constructions seem to be relatively rare in practice.
N06-1033
It is important not to preclude a formalism merely based on impracticality of its current use (given the constant increases in computer speed), but inherent intractability is another matter.7 6Palmer et al.(1999) provide an approach to STAG that attempts to address this particular problem as does the extension of Dras (1999).
P99-1011
