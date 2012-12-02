Marcu (1997b) lists their names and the number of instances in which each rhetorical relation was used.
P97-1013
research that uses part-of-speech tags in order to identify elementary unit boundaries, see Marcu (1999a).
P99-1047
Furthermore, the discourse trees that the rhetorical parser builds are more constrained structures (Marcu 2000): as a consequence, the rhetorical parser does not overgenerate invalid trees as Sumita et al.'s does.
A00-2002
The algorithm found 80.8% of the discourse markers with a precision of 89.5% (see Table 4), a result that seems to outperform Hirschberg and Litman's (1993) algorithm.
J93-3003
Other texts and semistructured HTML/SGML documents may need more sophisticated algorithms to solve this segmentation problem, such as those described by Palmer and Hearst (1997).
J97-1003 J97-2002
Rhetorical Structure Using a Well-Constrained Mathematical Model In my previous work (Marcu 1996, 1997b, 2000) I have formalized the constraints specific to valid rhetorical structures in the language of first-order logic.
A00-2002 P97-1013
In fact, some psycholinguistic and empirical research of Heurley (1997) and Hearst (1997) indicates that paragraph breaks do not always occur at the same locations as the thematic boundaries.
J97-1003
(See Marcu \[1999b\] for a mathematical formulation of this method that uses rhetorical structures for deriving a partial ordering of the important units in texts).
P99-1047
The rhetorical parser implements the proof-theoretic account as a chart-parsing algorithm (see Marcu \[2000\] for details).
A00-2002
Also, studies by Harabagiu, Moldovan, and Maiorano (Harabagiu and Maiorano 1996; Harabagiu and Moldovan 1999) show that cohesion can be used to determine rhetorical relations that hold between smaller discourse constituents as well.
W99-0104
The interested reader can find further detail in Marcu (2000).
A00-2002
Youmans (1991), Hoey (1991), Morris and Hirst (1991), Salton et al.(1995), Salton and Allan (1995), and Hearst (1997) have shown that word cooccurrences and more sophisticated forms of lexical cohesion can be used to determine segments of topical and thematic continuity.
J91-1002 J97-1003
They have extended the centering model proposed by Grosz, Joshi, and Weinstein (1995) by devising algorithms that build hierarchies of referential discourse segments.
J95-2003
The action DUAL is usually associated with cue phrases that can introduce some expectations about the discourse (Cristea and Webber 1997).
P97-1012
On the other hand, the theories aimed at characterizing the constraints that pertain to the structure of unrestricted texts and the computational mechanisms that would enable the derivation of these structures (van Dijk 1972; Zock 1985; Grosz and Sidner 1986; Mann and Thompson 1988; Polanyi 1988, 1996; Hobbs 1990) are either too informal or incompletely specified to support a fully automatic approach to discourse analysis.
J86-3001
The rhetorical-based summarizer that employs learning techniques to improve its performance is discussed in detail in Marcu (2000).
A00-2002
In step III.2, the rhetorical parser uses cohesion (Halliday and Hasan 1976; Hearst 1997; Hoey 1991; Salton et al.1995) to hypothesize rhetorical relations.
J97-1003
Kurohashi and Nagao (1994) describe a discourse structure generator that builds discourse trees in an incremental fashion.
C94-2183
In addition to the discourse relation signaled by a marker such as Although, which introduces expectations (Cristea and Webber 1997), I also found it useful to annotate the rhetorical relation that held between the sentence to which an expectation-based marker belonged and the text span that went before.
P97-1012
I believe that the research that comes closest to that described in this chapter is that of Sumita et al.(1992) and Kurohashi and Nagao (1994).
C94-2183
A cue phrase has a sentential role if it makes a semantic contribution to the interpretation of text (Hirschberg and Litman 1993).
J93-3003
In Section 4, I explain how the annotated data was used to derive algorithms that identify connective occurrences (Section 4.2), determine elementary units of discourse and determine which connectives have a discourse function (Section 4.3), and hypothesize rhetorical relations that hold between elementary units and spans of texts (Section 4.4). 405 Computational Linguistics Volume 26, Number 3 3.1 Materials Many researchers have published lists of potential discourse markers and cue phrases (Halliday and Hasan 1976; Grosz and Sidner 1986; Martin 1992; Hirschberg and Litman 1993; Knott 1995; Fraser 1996).
J86-3001 J93-3003 J95-2003
In contrast, experiments of Bruder and Wiebe (1990) and Wiebe (1994) show that paragraph breaks help readers to interpret private-state sentences in narratives, i.e., sentences about psychological states such as wanting and perceptual states such as seeing.
J94-2004
Hearst. 1997.
J97-1003
Marcu (1997b) provides a full description of the algorithm.
P97-1013
Recent research has shown that by exploiting the structure of discourse, one can decrease storage space in information retrieval applications (CorstonOliver and Dolan 1999) and address discourse-specific problems in machine translation (Marcu, Carlson, and Watanabe, 2000).
A00-2002
For example, Cristea et al.(1999) have shown that a hierarchical model of discourse has a higher potential for improving the performance of a coreference resolution system than a linear model of discourse.
W99-0106
corpus of instructional texts that was studied by Moser and Moore (1997) and Di Eugenio, Moore, and Paolucci (1997) reflected approximately the same distribution of cue phrases: 181 of the 406 discourse relations that they analyzed were cued relations.
P97-1011
(See Marcu \[2000\] for a complete list of these axioms).
A00-2002
And Morris and Hirst (1991) have also shown that there is a correlation between cohesion-defined textual segments and hierarchical, intentionally defined segments (Grosz and Sidner 1986).
J86-3001 J91-1002
A parallel line of research has been investigated recently by Strube and Hahn (1999).
J99-3001
Since the systems developed by Corston-Oliver (1998), Sumita et al.(1992), and Kurohashi and Nagao (1994) were not evaluated intrinsically, it is difficult to compare the performance of their systems to ours.
C94-2183
Empirical studies on the disambiguation of cue phrases (Hirschberg and Litman 1993) have shown that just by considering the orthographic environment in which they occur, one can distinguish between sentential and discourse uses in about 80% of cases and that these results can be improved with machine learning techniques (Litman 1996) or genetic algorithms (Siegel and McKeown 1994).
J93-3003
And Hirschman et al.(1999) have suggested that certain types of questions can be better answered if one has access to rhetorical structure representations of the texts that contain the answers to the questions.
P99-1042
On one hand, the theories developed in the traditional, truth-based semantic perspective (Kamp 1981; Lascarides and Asher 1993; Asher 1993; Hobbs et al.1993; Kamp and Reyle 1993; Asher and Lascarides 1994; Kameyama 396 Marcu Rhetorical Parsing of Unrestricted Texts 1994; Polanyi and van den Berg 1996; van den Berg 1996; Gardent 1997; Schilder 1997; Cristea and Webber 1997; Webber et al.1999) take the position that discourse structures can be built only in conjunction with fully specified clause and sentence syntactic structures.
P94-1006 P97-1012 P99-1006 W99-0106
When the textual units under consideration are characterized by no discourse markers, rhetorical relations are hypothesized on the basis of a simple cohesive device, which is similar to that used by Hearst (1997) (see lines 10-11).
J97-1003
In my previous work (Marcu 1996, 1997a, 1997b, 1999b, 2000), I have argued that rhetorical relations that hold between large textual spans can be explained in terms of similar relations that hold between their most important elementary units.
A00-2002 P97-1013 P99-1047
As I have shown in Marcu (2000), the proof-theoretic account outlined here is both sound and complete with respect to the constraints that characterize the valid rhetorical structures enumerated in Section 2.4.
A00-2002
