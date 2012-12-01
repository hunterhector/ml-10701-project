Both these problems require an account of the interface with pragmatics (see Copestake and Lascarides \[1997\] for one such account, which integrates probabilistic information into pragmatic reasoning).
P97-1018
Examination of the full range of rules proposed shows that Carpenter's (1991) postulated upper bound on the length of list-valued attributes such as SUBCAT in the lexicon cannot be maintained, leading to unrestricted generative capacity in constraint-based formalisms utilizing HPSG-style lexical rules.
J91-3003
One way of formalizing and implementing this approach is to adopt the covariation technique of Meurers and Minnen (1997) discussed in Section 2, in which finite-state machines (FSMs) representing the possible lexical rules that can apply to each basic lexical entry are associated with equivalence classes of such entries and the entry is simplified to information common between the variants.
J97-4003
However, it differs from recent proposals by, for example, Brew (1995), to associate probabilities with values on paths in a TFS formalism underlying HPSG, as the probabilistic information is much less fine-grained.
E95-1012
Meurers and Minnen (1997) present a computational framework for efficient application of Meurers' (1995) formalization of lexical rules.
J97-4003
Dative Constructions Lascarides, Copestake, and Briscoe (1996) present an account of the dative alternation that illustrates the utility of the TDFS framework for encoding defeasible lexical semantic entailments in terms of Dowty's (1989) proto thematic roles, and the interac4 We omit a formal proof as this would require more detailed specification of the syntactic component than is warranted in the rest of the paper.
W96-0303
We can model this aspect of language use as a conditional probability that a word form will be associated to a specific lexical entry, derived using a maximum likelihood estimator: 7 freq(lexical-entry with word-form) Pr°b(lexical-entry I w°rd-f°rm)= freq(word-form) This proposal is not novel and is the analogue of proposals to associate probabilities with initial trees in, for example, a lexicalized tree adjoining grammar (Resnik 1992; Schabes 1992).
C92-2066
We develop a restricted approach to lexical rules in a typed default feature structure (TDFS) framework (Lascarides et al.1995; Lascarides and Copestake 1999), which has enough expressivity to state, for example, rules of verb diathesis alternation, but which does not allow arbitrary manipulation of list-valued features.
J99-1002
This approach to deriving estimates of the productivity of lexical rules is applied to four denominal verb forma516 Briscoe and Copestake Lexical Rules tion rules in Briscoe and Copestake (1996), where the probabilities of the basic and derived word forms are estimated from part-of-speech tagged textual corpora.
W96-0303
The attraction of the current proposal, integrated with Meurers and Minnen's (1997) partial precompilation approach, is that we can do justice to the facts of semiproductivity and also achieve an efficient and maximally nonredundant encoding of the lexicon.
J97-4003
In the TDFS framework, an interface between the lexical component and syntactic-semantic component of the grammar is required so that some lexical default specification does not persist into the syntactic component (for example, defaults concerning grammatical agreement; see Lascarides and Copestake \[1999\]).
J99-1002
In this case, for word forms i in sentence: Prob(sent-interp) = II(lex-entry { word-form/) i In frameworks that incorporate alternative competing syntactic rule schemata or operations, it might be necessary to associate probabilities with such rules and treat the probability of a derivation as the combined product of the probability of the syntactic operations applied and the lexical entries utilized (e.g., Schabes 1992).
C92-2066
Recently, Bouma and van Noord (1994) have proposed a lexical rule of Adjunct Introduction, which can recursively add adverbial categories to the SUBCAT list of a verbal category.
P94-1021
RESULT: IRESULT: \[ACTIVE: npsign\] / / L ACTIVE : npsign J | ACTIVE : npsign J . r " " r 1 ~ r v-a~t-cause-make-intend-transfer SEM:< / ~.~ e e/'/~V~NT : e ' : ~ L ARG: x r p-pat-aff-obj r p-obl-benef \] \]EVENT:e • iEVENT:e | > L ARG: y L ARG: z J Figure 16 paint There are ways in which we could extend the formalism to avoid this problem, for instance by allowing specification of inequalities (Carpenter 1992), which could be used to explicitly prevent inappropriate coindexation (see Lascarides and Copestake \[1999\] for inequalities in the TDFS framework).
J99-1002
This probabilistic approach to lexical rules integrates neatly with extant proposals to control application of lexical rules efficiently within a constraint-based framework, such as those of Meurers and Minnen (1997).
J97-4003
E-mail: aac@csli.stanford.edu (~) 1999 Association for Computational Linguistics Computational Linguistics Volume 25, Number 4 Firstly, Carpenter (1991) demonstrates that if lexical rules are able to perform arbitrary manipulations (deletion, addition, and permutation) of potentially unbounded lists, any recursively enumerable language can be generated, even if the nonderived lexicon and grammar only generate context-free languages.
J91-3003
Copestake and Briscoe (1995) argue at some length for this position, and Lascarides and Copestake (1995) and Lascarides et al.(1995) show how lexical defaults interact appropriately with nonmonotonic discourse reasoning within the formal framework of DICE (Lascarides and Asher 1991, 1993).
P91-1008
511 Computational Linguistics Volume 25, Number 4 The frequency with which a given word form is associated with a particular lexical entry (i.e., sense or grammatical realization) is often highly skewed; Church and Mercer (1993) point out that a model of part-of-speech assignment in context will be 90% accurate (for English) if it simply chooses the lexically most frequent part-of-speech for a given word.
J93-1001
In any case, if these rules only apply to the output of the lexicon, this will avoid the increase in generative capacity identified by Carpenter (1991), resulting from the interaction of recursion, arbitrary list operations and unbounded lists, by keeping list-valued features bounded during lexical rule application, and only allowing unbounded additions to, or limited modification of, such features during syntactic processing.
J91-3003
In most previous accounts (see, for example, Bouma \[1992\], Carpenter \[1993\], Copestake \[1993\], and Russell et al.\[1993\]), default unification is an asymmetric operation that combines two ordinary (T)FSs, one of which is treated 492 Briscoe and Copestake Lexical Rules as default and one nondefault, to produce a normal TFS.
J92-2003
We will not discuss this further here, but see Baayen and Sproat (1996) for discussion of the related phenomenon of ambiguous derivational affixes.
J96-2001
Bouma and van Noord (1994) and Johnson and Dorre (1995) propose techniques for delayed evaluation of lexical rules so that they apply "on demand" at parse time.
P94-1021 P95-1014
In view of the unrestricted generative power of conventional HPSG-style lexical rules (Carpenter 1991), naive generative application of recursive or cyclic rules can lead to nontermination during parsing.
J91-3003
In the LOB corpus, there are about 18 times as many instances of believe in the most common subcategorization class (sentential complement) as in the four least common classes combined, and other multiple-complement-taking verbs show similar strong skews (e.g., Briscoe, Copestake, and Boguraev 1990).
C90-2008
Our approach to lexical rules improves this situation by formalizing them in terms of default unification utilizing existing operations in the typed default feature structure (TDFS) representation language (Lascarides et al.1995; Lascarides and Copestake 1999).
J99-1002
However, the TDFS approach extends formalized and implemented proposals for default inheritance, such as DATR (Evans and Gazdar 1989, 1996) or any version based on asymmetric unification, in that the lexicon now consists of a set of TDFSs, as opposed to a set of (T)FSs; that is, it permits default specification to persist "beyond the lexicon" for exploitation during syntactic, semantic, or discourse level operations.
E89-1009 J96-2002
A rule such as Adjunct Introduction (Bouma and van Noord 1994), which adds adjunct categories to the SUBCAT lists of verb entries recursively creating a potentially infinite set of derived entries, seems to us to be a clear example of a nonlexical unary syntactic rule.
P94-1021
Lascarides, Alex and Nicholas Ashen 1991.
P91-1008
Lascarides et al.(1995) provide an initial formalization of the TDFS framework, Lascarides and Copestake (1999: henceforth L&C) describe the version of default unification assumed in the informal outline of the TDFS formalism that follows.
J99-1002
Default inheritance has been widely exploited in lexical descriptions both within and outside the TFS framework (e.g., Daelemans, de Smedt, and Gazdar 1992).
J92-2004
