Therefore, we automatically construct lexical chains of WordNet relations from a1 ’s constituents to a0 ’s (Moldovan and Novischi, 2002).
C02-1167
In order to objectively evaluate our representation, we derived it from two different sources: constituency parse trees (generated with our implementation of (Collins, 1997)) and dependency parse trees (created using Minipar (Lin, 1998))1.
P97-1003
Calculus The Semantic Calculus axioms combine two semantic relations identified within a text fragment and increase the semantic connectivity of the text (Tatu and Moldovan, 2005).
H05-1047
(Bos and Markert, 2005) represents a1 and a0 into a first-order logic translation of the DRS language used in Discourse Representation Theory (Kamp and Reyle, 1993) and uses a theorem prover and a model builder with some generic, lexical and geographical background knowledge to prove the entailment between the two texts.
H05-1079
(de Salvo Braz et al., 2005) proposes a Description Logic-based knowledge representation language used to induce the representations of a1 and a0 and uses an extended subsumption algorithm to check if any of a1 ’s representations obtained through equivalent transformations entails a0 . 2 Cogex A Logic Prover for NLP Our system uses COGEX (Moldovan et al., 2003), a natural language prover originating from OTTER (McCune, 1994).
N03-1022
Form Transformation In the first stage of our representation process, COGEX converts a1 and a0 into logic forms (Moldovan and Rus, 2001).
P01-1052
