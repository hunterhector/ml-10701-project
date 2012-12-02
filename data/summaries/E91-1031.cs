Unificationbased versions of Categorial Grammar, known as CUG or UCG, have attracted considerable attention recently (see, for instance, Uszkoreit, 1986, Karttunen, 1986, Bouma, 1988, Bouma et al., 1988, and Calder et al., 1988).
C86-1045 C88-1018
Parsing methods for context-free grammar can be extended to unification-based grammar formalisms (see Shieber, 1985 or Haas, 1989), and therefore they can in principle be used to parse CUG.
J89-4001 P85-1018
Whereas Haas (1989) found that top-down filtering never helps to actually decrease parse times in a bottom-up parser, we have found at least one example (German) where top-down filtering is useful.
J89-4001
Shieber, 1985).
P85-1018
For UGs which lack a so-called context-free back-bone, such as CUG, the top-down prediction step can only be guaranteed to terminate if we make use of restriction, as defined in Shieber (1985).
P85-1018
Comparing our results with those of Shieber (1985) and Haas (1989), we see that in all cases top-down filtering may reduce the size of the chart significantly.
J89-4001 P85-1018
This multiplication may lead to a needlessly large left-corner table, which, if used in the prediction step, may in fact lead to sharp decreases in parsing performanee (see also Haas, 1989, who encountered similar problems).
J89-4001
Results The performance of the parsing algorithms discussed in the preceding sections (a bottom-up parser for UG (BU), a top-down parser for UG (of Shieber, 1985) (TD), a top-down parser operating on an instantiated grammar (TD/1), and a bottom-up parser with topdown filtering operating on an instantiated grammar (BU/LC)) were tested on two experimental CUGs, one implementing the morphosyntactic features of German N Ps, and one implementing the syntax of WH-questions in Dutch by means of a gap-threading mechanism.
P85-1018
