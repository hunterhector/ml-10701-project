Brennan, Friedman, and Pollard (1987) also allow the Cb(Ui_I) to remain undefined.
P87-1022
In a seminal paper, Grosz and Sidner (1986) wrapped up the results of their research and formulated a model in which three levels of discourse coherence are distinguished--attention, intention, and discourse segment structure.
J86-3001
The extended version assumes a detailed treatment of a particular subset of inferables, so-called functional anaphora (in Hahn, Markert, and Strube \[1996\], functional anaphora are referred to as textual ellipses).
P96-1036 P96-1057
Cb(Ui) = Cp(Ui) CONTINUE SMOOTH-SHIFT Cb(Ui) ~ Cp(Ui) RETAIN ROUGH-SHIFT Weinstein (1983, 1995) and Brennan, Friedman, and Pollard (1987) is that the latter use two SHIFT transitions instead of only one: SMOOTH-SHIFT 8 requires the Cb(Ui) to equal Cp(Ui), while ROUGH-SHIFT requires inequality (Table 5).
P87-1022
Other cases, such as VP anaphora (Hardt 1992), temporal anaphora (Kameyama, Passonneau, and Poesio 1993; Hitzeman, Moens, and Grover 1995) have already been examined within the centering model.
E95-1035 P92-1002 P93-1010
As a consequence, we have redefined Rule 2 of the Centering Constraints (Grosz, Joshi, and Weinstein 1995, 215) appropriately.
J95-2003
This is the type of discourse to which centering was mainly applied in previous approaches (see, for example, Walker's \[1989\] or Di Eugenio's \[1998\] test sets).
P89-1031
Suri and McCoy (1994) in their RAFT/RAPR approach use grammatical roles for ordering the focus lists and make a distinction between Subject Focus, Current Focus, and corresponding lists.
J94-2006
The Centering Model The centering model (Grosz, Joshi, and Weinstein 1983, 1995) is intended to describe the relationship between local coherence and the use of referring expressions.
J95-2003 P83-1007
While this paper gives a comprehensive picture of a complex, yet not explicitly spelled-out theory of discourse coherence, the centering model (Grosz, Joshi, and Weinstein, 1983, 1995) marked a major step in clarifying the relationship between attentional states and (local) discourse segment structure.
J95-2003 P83-1007
Strube (1996b) (with respect to centering) and Suri and McCoy (1994) (with respect to the focus model) describe similar approaches and provide algorithms for the interaction of the resolution of interand intrasentential anaphora, but the topic has certainly not been dealt with exhaustively.
J94-2006 P96-1036 P96-1057
In order to apply the centering model to pronoun resolution, they use Rule 2 in making predictions for pronominal reference and redefine the rules as follows (quoting Walker, Iida, and Cote \[1994\]): Rule 1' If some element of Cf(Ui-1) is realized as a pronoun in Ui, then so is Cb(Ui).
J94-2003
linking conceptual relation between these two discourse elements has to be inferred in order to make it explicit at the level of text knowledge representation structures (for an early statement of this idea in terms of "bridging" inferences, see Clark \[1975\]).
T75-2034
The particular phenomenon of paycheck anaphora is described by Hardt (1996), though he uses only a rather simplified centering model for this work.
C96-1088
The extension of functional centering to these phenomena is presented in Hahn and Strube (1997), while Walker (1998) builds upon the centering algorithm described in Brennan, Friedman, and Pollard (1987).
P87-1022 P98-2204
The more figurative names were introduced by Walker, Iida, and Cote (1994).
J94-2003
The term context-bound in Strube and Hahn (1996) corresponds to the term evoked used by Prince.
P96-1036 P96-1057
It is assumed that discourses are composed of constituent segments (Grosz and Sidner 1986), each of which consists of a sequence of utterances.
J86-3001
Centering Grosz, Joshi, and Weinstein (1995) admit that several factors may have an influence on the ranking of the Cf but limit their exposition to the exploitation of grammatical roles only.
J95-2003
(10a) (10b) 00c') (10d) (10d') Cf: Cf: Cf: Cf: Cf: \[BRENNANu: Brennan, ALFA ROMEOBN: Alfa Romeo\] \[BRENNANE: she\] \[BRENNANE: her, DRIVERBN: driver\] \[BRENNANE: she\] \[BRENNANE: she, DRIVERE: her\] 5.6 Summary of Evaluation To summarize the results of our empirical evaluation, we claim, first, that our proposal based on functional criteria leads to substantially improved and--with respect to the inference load placed on the text understander, whether human or machine--more plausible results for languages with free word order than the structural constraints given by Grosz, Joshi, and Weinstein (1995) and those underlying the naive approach.
J95-2003
The d-binding criterion we have developed for resolving intrasentential anaphora is based on dependency grammar notions described in more detail in Strube and Hahn (1995).
E95-1033
Our own work on the centering model 1 (Strube and Hahn 1996; Hahn and Strube 1996) brings in evidence from German, a free-word-order language in which grammatical role information is far less predictive of the organization of centers than for fixed-word-order languages such as English.
P96-1036 P96-1057
After a brief in311 Computational Linguistics Volume 25, Number 3 troduction into what we call the "grammatical" centering model (actually, a recap of Grosz, Joshi, and Weinstein \[1995\]) in Section 3, we turn in Section 4 to our approach, the functional model of centering.
J95-2003
Since in this paper we will not discuss the topics of global coherence and discourse macro segmentation (for recent treatments of these issues, see Hahn and Strube \[1997\] and Walker \[1998\]), we assume a priori that any centering data structure is assigned an utterance in a given discourse segment and simplify the notation of centers to Cb(Ui) and Cf(Ui).
P98-2204
While the RETAIN-SHIFT combination in examples (10c) and (10d') (slightly modified from Brennan, Friedman, and Pollard \[1987, 157\]) did not indicate a difference between the approaches, for the RETAIN-CONTINUE combination in examples (10c) and (10d), the two approaches led to different results (see Table 22 for the BFP algorithm and Table 23 for the FunC algorithm).
P87-1022
the examples in the next section and the in-depth treatment in Hahn, Markert, and Strube \[1996\]) is usually only sketchily dealt with in the centering literature, e.g., by asserting that the entity in question "is realized but not directly realized" (Grosz, Joshi, and Weinstein 1995, 217).
J95-2003 P96-1036 P96-1057
We achieved consistent results for the grammatical and the functional approach for all the examples contained in Grosz, Joshi, and Weinstein (1995) but found diverging analyses for some examples discussed by Brennan, Friedman, and Pollard (1987).
J95-2003 P87-1022
So, we screened sample data from the literature, which were already annotated by centering analyses (for English, we considered all examples discussed in Grosz, Joshi, and Weinstein \[1995\] and Brennan, Friedman, and Pollard \[1987\]).
J95-2003 P87-1022
Strube (1998) provides a complete specification for dealing with complex sentences, but this approach departs significantly from the centering model.
P98-2204
Grosz, Joshi, and Weinstein (1995) also define two rules on center movement and realization: 314 Strube and Hahn Functional Centering clauses tensed embedded same-level inaccessible accessible, less salient I I direct speech non-report complements reported speech relative clauses Figure 1 Kameyama's intrasentential centering categorization.
J95-2003
This is often done in an admittedly ad hoc way, requiring tricky retuning when new evidence is added (Rich and LuperFoy 1988).
A88-1003
Since Grosz, Joshi, and Weinstein (1995) and Brennan, Friedman, and Pollard (1987) do not give a reasonable definition of utterance, we follow Kameyama's (1998) method for dividing a sentence into several center-updating units (Figure 1).
J95-2003 P87-1022
Hence, proposals were made to replace these high-level "symbolic" categories by statistically interpreted occurrence patterns derived from large text corpora (Dagan and Itai 1990).
C90-3063
In order to analyze Turkish texts, Hoffman (1996, 1998) distinguishes between the information structure of utterances and centering, since both constructs are assigned different functions for text understanding.
C96-1094
The ordering constraints we supply account for all of the types of anaphora mentioned above, including (pro)nominal anaphora (Strube and Hahn 1995; Hahn and Strube 1996).
E95-1033 P96-1036 P96-1057
These combine the variety of available evidence, each one usually annotated by a specific weight factor, and, finally, map the weights to a single salience score (Rich and LuperFoy 1988; Haji~ovG KuboG and Kubo~ 1992; Lappin and Leass 1994) These heuristics helped to improve the performance of discourse-understanding systems through significant reductions of the available search-space for antecedents.
A88-1003 J94-4002
We did not account for false positives and error chains, but marked the latter (see Walker 1989).
P89-1031
Information Structure and Centering As far as the centering model is concerned, the first account involving information structure criteria was given by Kameyama (1986) and further refined by Walker, Iida, and Cote (1994) in their study on the use of zero pronouns and topic mark9 Walker, Iida, and Cote (1994) note that it is possible to improve the computational efficiency of the algorithm by interleaving generating, filtering, and ranking steps; cf.
J94-2003 P86-1031
The following list mentions only the most pertinent issues that have come to our attention and complements the list given by Grosz, Joshi, and Weinstein (1995): . . The centering model is rather agnostic about the intricacies of complex sentences such as relative clauses, subordinate clauses, coordinations, and complex noun phrases.
J95-2003
Using these proposals as a point of departure, we shall develop our own proposal--functional centering (Strube and Hahn 1996).
P96-1036 P96-1057
8 Brennan, Friedman, and Pollard (1987) call these transitions SHIFTING and SHIFTING-1.
P87-1022
It contains additional material from the doctoral thesis of the first author (Strube 1996a).
P96-1036 P96-1057
A resolution module for (pro)nominal anaphora (Strube and Hahn 1995) and one for functional anaphora (Hahn, Markert, and Strube 1996) based on this functional centering model has been implemented as part of PARSETALK, a comprehensive text parser for German (Hahn, Schacht, and Br6ker 1994; Hahn, Neuhaus, and Br6ker 1997) in our group.
E95-1033 P96-1036 P96-1057
By shifting our evaluation criteria away from resolution success data to structural conditions reflecting the proper ordering of center lists (in particular, we focus on the most highly ranked item of the forward-looking centers), these criteria are intended to compensate for the a significant improvement in the results, is proposed in Strube (1998).
P98-2204
It does not, however, take into account several "hard" issues such as plural anaphora, generic definite noun phrases, propositional anaphora, and deictic forms (but see Eckert and Strube \[1999\] for a treatment of discourse-deictic anaphora in dialogues within a centering-type framework).
E99-1006
of the Centering Transitions Our use of the centering transitions led us to the conclusion that CONTINUE and SMOOTH-SHIFT are not completely specified by Grosz, Joshi, and Weinstein (1995) and Brennan, Friedman, and Pollard (1987).
J95-2003 P87-1022
The two versions differ with respect to the incorporation of (a subset of) inferables in the second version and, hence, with respect to the requirements 10 In Strube and Hahn (1996), we assumed that the information status of a discourse entity has the main impact on its salience.
P96-1036 P96-1057
article is an extended and revised version of our contribution to the 1996 Annual Meeting of the Association for Computational Linguistics (Strube and Hahn 1996).
P96-1036 P96-1057
One interpretation is due to Brennan, Friedman, and Pollard (1987) who utilize Rule 2 for computing preferences for antecedents of pronouns (see Section 3.2).
P87-1022
The centering model differs from these considerations in that it aims at unfolding a unified theory of discourse coherence at the linguistic, attentional, and intentional level (Grosz and Sidner 1986); hence, the search for a more principled, theory-based solution, but also the need for (almost) perfect linguistic analyses in terms of parsing and semantic interpretation.
J86-3001
Originally, in Strube and Hahn (1996), we defined the Cf ranking criteria in terms of contextboundedness.
P96-1036 P96-1057
A first proposal for how to deal with center ambiguity in an incremental text parser has been made by Hahn and Strube (1996).
P96-1036 P96-1057
the relation PART-OF between the concepts RECHARGEBATTERYCELL and 316LT, is available (see Hahn, Markert, and Strube \[1996\] for a detailed treatment of the resolution of inferables).
P96-1036 P96-1057
In this section, we first discuss two studies in which the information structure of utterances is already integrated into the centering model (Rambow 1993; Hoffman 1996, 1998).
C96-1094
Following Walker (1989), a discourse segment is defined as a paragraph unless its first sentence has a pronoun in subject position or a pronoun whose syntactic features do not match the syntactic features of any of the preceding sentence-internal noun phrases.
P89-1031
In fact, Walker, Iida, and Cote (1994) hypothesize that the Cf ranking criteria are the only language-dependent factors within the centering model.
J94-2003
Their algorithm (Table 6) consists of three basic steps (as described by Walker, Iida, and Cote \[1994\]).
J94-2003
It relates differences in coherence (in part) to varying demands on inferences as required by different types of referring expressions, given a particular attentional state of the hearer in a discourse setting (Grosz, Joshi, and Weinstein 1995, 204-205).
J95-2003
Computational linguists have recognized the need to account for referential ambiguities in discourse and have developed various theories centered around the notion of discourse focus (Grosz 1977; Sidner 1983).
P83-1007
Brennan, Friedman, and Pollard (1987) utilize this rule for anaphora resolution but restrict it to single transitions.
P87-1022
In general, it might become increasingly necessary to integrate very deep forms of reasoning, perhaps even nonmonotonic (Dunin-Keplicz and Lukaszewicz 1986) or abductive inference mechanisms (Nagao 1989), into the anaphora resolution process.
C86-1119
We here restrict inferables to the particular subset defined by Hahn, Markert, and Strube (1996), which we call functional anaphora (FA).
P96-1036 P96-1057
of Rule 2 Grosz, Joshi, and Weinstein (1995) define Rule 2 of the centering model on the basis of sequences of transitions.
J95-2003
In addition, an explicit relation to basic notions from speech act theory is also missing, though it should be considered vital for the global coherence of discourse (Grosz and Sidner 1986).
J86-3001
On the other hand, many of these systems work in a real-world environment (Rich and LuperFoy 1988; Lappin and Leass 1994; Kennedy and Boguraev 1996) in which noisy data and incomplete, sometimes even faulty, analysis results have to be accounted for.
A88-1003 C96-1021 J94-4002
While it is usually assumed that the functional anaphor (FA) is ranked above its antecedent (FA ante) (Grosz, Joshi, and Weinstein 1995, 217), we assume the opposite.
J95-2003
In the third column of Table 18, we give the numbers of transitions generated by the grammatical constraints (Table 1) stated by Grosz, Joshi, and Weinstein (1995, 214, 217).
J95-2003
The centering model as formulated by Grosz, Joshi, and Weinstein (1995) refines the structure of "centers" of discourse, which are conceived as the representational device for the attentional state at the local level of discourse.
J95-2003
Brennan, Friedman, and Pollard (1987) extend the ordering constraints in Cf in the following way: "We rank the items in Cf by obliqueness of grammatical relations of the subcategorized functions of the main verb: that is, first the subject, object, and object2, followed by other subcategorized functions, and finally, adjuncts".
P87-1022
Both Rambow (1983) as well as Hoffman (1996, 1998) argue for a correlation between the information structure of utterances and centering.
C96-1094
Grosz, Joshi, and Weinstein (1995) state that the items in the Cf list have to be ranked according to a number of factors including grammatical role, text position, and lexical semantics.
J95-2003
BFP Algorithm The centering algorithm described by Brennan, Friedman, and Pollard (1987, henceforth BFP algorithm) interprets the centering model in a certain way and applies it to the resolution of pronouns.
P87-1022
