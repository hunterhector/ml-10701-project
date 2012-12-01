In its emphasis on description-based techniques, our approach shares some fundamental features with the one proposed by Kay (1984), but we use an explicit projection mechanism to separate out and organize the intraand inter-language components.
P84-1018
Although we have split up the different equations among several projections for conceptual clarity, computationally we can consider them to define one big attribute value structure with X and z as special attributes, so the generation problem in this framework reduces to the problem of generating from attribute-value structures which are formally of the same type as f-structures (see Halvorsen and Kaplan (1988), Wedekind (1988), and Momma and D6rre (1987) for discussion).
C88-1060 C88-1061 C88-2150
Second, Kaplan (1988) and Halvorsen and Kaplan (1988) discuss other methods for deriving the descriptions necessary to determine these abstract structures.
C88-1060 C88-1061
Wedekind, JQrgen (1988) Generation as Structure Driven Derivation.
C88-2150
For example, Kaplan and Maxwell (1988a) exploit this capability to describe semantic structures for coordinate constructions which necessarily contain the logical conjunction appropriate to the string even though there is no reasonable place for that conjunction to be marked in the f-structure.
C88-1060 C88-1061
Kudo, Ikuo and Hirosato Nomura (1986) Lexical-Functional Transfer: A Transfer Framework in a Machine Translation System based on LFG.
C86-1024
Isabelle, Pierre and Elliott Macklovitch (1986) Transfer and MT modularity.
C86-1025
Kaplan, Ronald and John Maxwell (1988b).
C88-1060 C88-1061
Kay, Martin (1984) Functional Unification Grammar: A formalism for Machine Translation.
P84-1018
Kaplan, Ronald (1988) Correspondences and their inverses.
C88-1060 C88-1061
Let us assume that relative clauses can be analyzed by the following slightly simplified phrase structure rules, making use of functional uncertainty (see Kaplan and Maxwell 1988b for a technical discussion of functional uncertainty) to capture the non-local dependency of the relativized phrase (equations on the head NP are ignored): (12) NP ~ NP S' ( I' RELADJ)= S t ..~ XP S (1' REL-TOPIC) = J, 1' = ~, ( 1` XCOMP* GF) = ~, We can achieve the desired correspondence between the source and the target by augmenting the first rule with the following transfer equations: (13) NP --* NP S ! ( 1` RELADJ) = • ~( 1` RELADJ) = (z i' RELADJ) z( ~ REL-TOPIC)ffi (~ ~ REL-TOPIC) The effect of this rule is that the ~ value of the relativized phrase (REL-TOPIC) in the source language is identified with the relativized phrase in the target language.
C88-1060 C88-1061
We also achieve modularity of a more basic sort: our correspondence mechanism permits contrastive transfer rules that depend on but do not duplicate the specifications of independently motivated grammars of the source and target languages (Isabelle and Macklovitch, 1986; Netter and Wedekind, 1986).
C86-1025
This approach relies mainly on codescription, and thus it is different from other aFG-based approaches that use a 280description-by-analysis mechanism to relate the f-structure of a source language to the f-structure of a target language (see for example Kudo and Nomura, 1986).
C86-1024
Kaplan, Ronald and John Maxwell (1988a).
C88-1060 C88-1061
Halvorsen and Kaplan (1988), for example, discuss a level of semantic structure that encodes predicate-argument relations and quantifier scope, information that does not enter into the kinds of syntactic generalizations that the f-structure supports.
C88-1060 C88-1061
Halvorsen, Per-Kristian and Ronald Kaplan (1988) Projections and semantic description.
C88-1060 C88-1061
First, this framework has been generalized to additional kinds of structures that represent other subsystems of linguistic information (Kaplan, 1987; Halvorsen, 1988).
C88-1060 C88-1061
