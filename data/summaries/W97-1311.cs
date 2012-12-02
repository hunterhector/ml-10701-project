Our approach can be compared to that of Whittemore and Macpherson (1991) who discuss incremental building of event representations within a modified form of DRT (Kamp, 1981).
P91-1003
The prototypical IE tasks are those specified in the Message Understanding Conference (MUC) evaluations (DARPA, 1995; Grishman and Sundheim, 1996).
C96-1079
Interpretation The LaSIE system's 'world' or domain of interest is modelled by an inheritance-based semantic graph, using the XI knowledge representation language (Gaizauskas, 1995).
M95-1017
However, the general approach here has more in common with Whittemore and Macpherson (1991) or Zarri (1992), where event merging is carried out within the underlying knowledge representation.
P91-1003
Sown (1984) or Appelt et al.(1995)), but a more generally useful 4Of course in some events, roles may be filled by other events, but this complication does not affect the basic point that object coreference is primary and event coreference dependent upon it.
M95-1019
The overall contributions of these stages may be briefly described as follows (see Gaizauskas et al.(1995) for further details): lexical preprocessing reads and tokenises the raw input text, tags the tokens with parts-ofspeech, performs morphological analysis, performs phrasal matching against lists of proper names; parsing and semantic interpretation builds lexical and phrasal chart edges in a feature-based formalism then does two pass chart parsing, pass one with a special named entity grammar, pass two with a general grammar, and, after selecting a 'best parse', constructs a predicate-argument representation of the current sentence; discourse interpretation adds the information from the predicate-argument representation to a hierarchically structured semantic net which encodes the system's world model, adds additional information presupposed by the input, performs coreference resolution between new and existing instances in the world model, and adds any information consequent upon the new input.
M95-1017
This paper discusses an approach to handling event coreference as implemented in the LaSIE information extraction system (Gaizauskas et al., 1995; Gaizauskas and Humphreys, 1997b).
M95-1017
The constraints above are similar to those used in the FASTUS IE system (Appelt et al., 1995) and by Sown (1984), where the merging takes place between template structures, considering special conditions for the unification of variables in template slots.
M95-1019
