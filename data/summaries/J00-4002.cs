These constructs correspond as directly as possible to properties of the linguistic structure that express them and are, to as small an extent as possible, dependent on the requirements of contextual resolution (unlike, say, the metavariables of standard QLFs \[Alshawi and Crouch 1992\], or the labels of UDRS \[Reyle 1996\], which are motivated entirely by the mechanisms that operate on them after grammatical processing).
P92-1005
An extension of some of these analyses can be found in 509 Computational Linguistics Volume 26, Number 4 Gardent and Kohlhase \[1996a\]).
C96-1073 P96-1001
with Deductive Interpretation It is interesting to compare this analysis with that described in Dalrymple, Shieber, and Pereira (1991) and Pereira (1990, 1991).
J90-1001
This equivalence is doing essentially the same job as Pereira's pronoun abstraction schema in Pereira (1990).
J90-1001
only the available five relative scopings of the quantifiers are produced (Hobbs and Shieber 1987, 47), but without the need for a free variable constraint--the HOU algorithm will not produce any solutions in which a previously bound variable becomes free; • the equivalences are reversible, and thus the above sentences can be generated from scoped logical forms; • partial scopings are permitted (see Reyle \[1996\]) • scoping can be freely interleaved with other types of reference resolution; • unscoped or partially scoped forms are available for inference or for generation at every stage.
J87-1005
We then go on to compare the current approach with that of some other theories with similar aims: the "standard" version of quasi-logical form implemented in the Core Language Engine, as rationally reconstructed by Alshawi and Crouch (1992) and Crouch and Pulman (1994); underspecified Discourse Representation Theory (Reyle 1993); and the "glue language" approach of Dalrymple et al.(1996). Finally, we discuss some of the semantic and logical issues raised by the approach described here, in particular the extent to which the theory meets the desiderata for accounts of underspecification outlined by van Eijck and Jaspars (1996), and the extent to which the theory supplies a methodologically satisfactory account of truth and interpretation for sentences involving contextually dependent constructs.
J94-4005 P92-1005
8 5.3 Underspecified Discourse Representation Structures In a series of papers, Reyle (1993, 1995, 1996) has elaborated a version of DRT that is able to represent quantifier scope and other ambiguities in a single underspecified representation.
E95-1001
existsl(&e.pos(pres(use(e,every(.>t,>~(manager),ac.,t),.(com puter)))) We assume that every determiner has its own equivalence, which resolves it as a quantifier: sometimes this can be quite a complicated matter, as with any (Alshawi 1990), which will resolve in different ways depending on its linguistic context, but here we avoid this complexity.
J90-3001
But no extralogical mechanisms are needed, apart from the definition of "parallel," which is intended to correspond to the notion discussed in Dalrymple, Shieber, and Pereira (1991), Prfist (1992), Hobbs and Kehler (1997), and Gardent and Kohlhase (1997), among others.
P97-1051
Not surprisingly, we can adapt a version of the HOU approach to ellipsis resolution (Dalrymple, Shieber, and Pereira 1991; Pulman 1991; Gawron 1992, 1995) very easily within this framework.
E91-1002
There are some similarities between the UDRS and the glue language approaches, as detailed in Crouch and van Genabith (1997).
P97-1052
this case, and for many other types of restrictions currently handled by conditions, more elegant solutions are available using the "sorted" and "colored" versions of higher-order unification developed by Michael Kohlhase and colleagues (Gardent and Kohlhase 1996b, 1997; Gardent Kohlhase, and van Leusen 1996; Gardent, Kohlhase, and Konrad 1999).
C96-1073 P96-1001
In the CLE-QLF approach, as ra519 Computational Linguistics Volume 26, Number 4 tionally reconstructed by Alshawi and Crouch (1992) and Crouch and Pulman (1994), the context-independent meaning of a sentence is given by one or more QLFs that are built directly from syntactic and semantic rules.
J94-4005 P92-1005
The resolution mechanism is not intended to be reversible, although by redefining resolution rules, reversibility is achievable to some extent within the limitations just discussed (Hurst 1994).
C94-1090
Determining whether an equivalence applies to a QLF or an RLF is done by higher-order unification (henceforth, HOU) (Huet 1975; Miller and Nadathur 1986; Pulman 1991; Dalrymple, Shieber, and Pereira 1991; Gawron 1992) of the logical form with the relevant pattern.
E91-1002 P86-1037
But the general outlines are reasonably clear, and we can adapt some of the UDRS (Reyle 1995) work to our own framework.
E95-1001
We can begin to capture such inferences by using proof rules for QLFs (partly modeled after those for UDRS in Reyle \[1995\]) such as these: CONJ: (where R is resolved, and Q may contain some unresolved constructs) R&Q R QUANT: (where Q is a downward monotone determiner, and P does not contain a negative) Pe~,t(Q~eo,t~,o(Roo,t)) exists(R,P) CONJ and QUANT need considerable refinement in order to cover more than the simplest cases, but they will give the correct results for the latter two examples.
E95-1001
A third problem arises with the approach to the semantics of QLFs that this notion of the relationship between QLF and RQLF encourages one to adopt: it is that taken by Alshawi and Crouch (1992).
P92-1005
The version proposed here combines a basic insight from Lewin (1990) with higher-order unification to give an analysis that has a strong resemblance to that proposed in Pereira (1990, 1991), with some differences that are commented on below.
C90-3034 J90-1001
For concreteness, we are assuming here that QLFs are built using a simple unification grammar formalism of the type described in Pulman (1996), and that a chart parser and semantic head-driven generator are 498 Pulman Bidirectional Contextual Resolution . . used for the analysis of sentences to QLFs and vice versa.
J96-3001
499 Computational Linguistics Volume 26, Number 4 . QLFs are interpreted by conditional equivalences (Rayner and Alshawi 1992; Rayner 1993) of the form: QLF ~:~ RLF if Conditionl,,..v Conditionn.
A92-1001 P92-1005
The more conservative approach is to try to integrate existing statistical disambiguation schemes for QLFs, either individually or in a "packed" structure (Alshawi and Carter 1994), with the resolution process as described here.
J94-4005
It uses a simple unification grammar (based on the formalism described in 516 Pulman Bidirectional Contextual Resolution (Pulman, 1996)) to produce QLFs.
J96-3001
5. Comparison with Alternative Approaches 5.1 Core Language Engine Quasi-Logical Form The starting point for the approach followed here was a dissatisfaction with certain aspects of the theory of quasi-logical form as described in Alshawi (1990, 1992), and implemented in SRI's Core Language Engine (CLE).
J90-3001 P92-1005
It has proved itself amenable to a large-scale implementation of impressive coverage, generality, and relative efficiency (Alshawi 1992).
P92-1005
