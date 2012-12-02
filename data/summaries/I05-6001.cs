The choice of RMRS also ensures that the semantic bank can be used for comparative evaluation of HPSG grammars with low-level parsers that output partial semantics in terms of RMRS, such as the RASP parser of Carroll and Briscoe (2002).
C02-1013
In order to bridge this gap, we construct an RMRS “treebank” from a subset of the TIGERDependencyBank (Forst et al., 2004), which can serve as a gold standard for HPSG parsing for evaluation, and for training of stochastic HPSG grammar models.
W04-1905
Conversion Similar to the TIGER to TIGER-DB conversion (Forst, 2003; Forst et al., 2004), we are using the term rewriting system of Crouch (2005) for treebank conversion.
W04-1905
Finally, the bag 3Copestake et al.(2001) mention a third feature to be included in the hook as an externally visible variable, which they instantiate with the index of the controlled subject in equi constructions and which is also used to implement the semantics of predicative modification.
P01-1019
Originally designed for machine translation, the system is a powerful rewriting tool that has been applied to other tasks, such as frame semantics construction (Frank and Erk, 2004), or induction of knowledge representations (Crouch, 2005).
W04-1906
Algebra for Semantic Construction Copestake et al.(2001) define a semantic entity as a 5-tuple 〈s1,s2,s3,s4,s5〉 such that s1 is a hook, s2 is a (possibly empty) set of holes, s3 and s4 are bags of Elementary Predications (EPs) and handle constraints, respectively, and s5 is a set of equalities holding between variables.
P01-1019
For (R)MRS construction from dependencies we follow the algebra for semantics composition in Copestake et al.(2001). In HPSG implementations of this algebra, composition is triggered by phrasal configurations.
P01-1019
In future research, we will investigate how the semantic algebra of Copestake et al.(2001) 9 compares to Glue Semantics (Dalrymple, 1999).
P01-1019
A more theory-neutral dependency representation is currently derived from this TIGER-LFG treebank for cross-framework parser evaluation (Forst et al., 2004).
W04-1905
We show how to adapt the construction principles of the semantic algebra of Copestake et al.(2001) to RMRS construction from dependencies in a rewrite scenario, and discuss the treatment of some special phenomena, such as verbal complementation, coordination and modification.
P01-1019
Otherwise, composition strictly follows the semantic operations of the algebra of Copestake et al.(2001): the composition rules only refer to the hook and slots of functors and arguments, to achieve the binding of argument variables and the encoding of scope constraints.
P01-1019
Our method effectively performs automatic RMRS semantics construction from functional dependencies, following the semantic algebra of Copestake et al.(2001). We present the semantics construction mechanism, and focus on some special phenomena.
P01-1019
Modification The algebra of Copestake et al.(2001) defines modifiers to externalise the variable of the ARG1.
P01-1019
