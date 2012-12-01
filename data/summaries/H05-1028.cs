Many theories on linguistic salience have been developed, including how the salience of entities affects the form of referring expressions as in the Givenness Hierarchy (Gundel et al., 1993) and the local coherence of discourse as in the Centering Theory (Grosz et al., 1995).
J95-2003
Therefore, in Equation (1), is the selection probability which indicates the likelihood of selecting an entity e given a gesture at time t i . This selection probability is calculated by a function of the distance between the location of the entity and the focus point of the recognized gesture on the display (Chai et al., 2004a).
P04-1001
Recently, we have seen work on language understanding based on environment (Schuler 2003) and language modeling using visual context (Roy and Mukherjee 2005).
P03-1067
The data collected from our previous user studies were used in our evaluation (Chai et al., 2004b).
P04-1001
Multimodal conversational systems promote more natural and effective human machine communication by allowing users to interact with systems through multiple modalities such as speech and gesture (Cohen et al., 1996; Johnston et al., 2002; Pieraccini et al., 2004).
P02-1048
Most salience-based interpretation has focused on reference resolution for both linguistic referring expressions (e.g., pronouns) (Lappin and Leass 1995) and multimodal expressions (Hul et al.1995; Eisenstein and Christoudias 2004).
N04-1004
Our previous work (Chai et al., 2004b) also showed that 85% of time gestures occurred before corresponding speech units.
P04-1001
Since currently we only use gesture 0.1 0.2 0.3 0.4 0.5 0.6 0.7 123456789101 User index W o rd E rro r R a t e Baseline Salience driven model Figure 5: Comparison of the baseline and the result from post-processing in terms of WER 1 The difference between the number of user inputs reported here and that in (Chai et al., 2004b) was caused by the situation where one intended user input (which was the unit for counting in our previous work) was split into a couple turns (which constitute the new counts here).
P04-1001
For semantically-rich modalities such as speech and penbased gesture, mutual disambiguation usually happens at the fusion stage where partial semantic representations from individual modalities are disambiguated and combined into an overall interpretation (Johnston 1998, Chai et al., 2004a).
P04-1001 P98-1102
A number of researchers have shown that the class-based N-gram model can successfully improve the performance of speech recognition (Jelinek 1990, Heeman 1999, Kneser and Ney 1993, Samuelsson and Reichl, 1999).
W99-0617
This allows the development of powerful language models independent of the acoustic model, for example, utilizing topics of the utterances (Gildea and Hofmann 1999), syntactic or semantic labels (Heeman 1999), and linguistic structures (Chelba and Jelinek 2000, Wang and Harper 2002).
W02-1031 W99-0617
More specifically, we use a class-based bigram model from (Brown et al, 1992): )|()|()|( 11 −− = iiiiii ccPcwPwwP (3) In Equation (3), c i is the class of the word w i, which could be a syntactic class or a semantic class.
J92-4003
The language model is computed as follows: * arg max ( | ) ( )O= )|()...|()|()()( 1 12131211 − = n n n wwPwwwPwwPwPwP Using the Markov assumption, the language model can be approximated by a bigram model as in: ∏ = − = n i ii n wwPwP 1 11 )|()( To improve the speech understanding results for spoken language interfaces, many systems have applied a loosely-integrated approach which decouples the language model from the acoustic model (Zue et al., 1991, Harper et al., 2000).
A00-2014
Currently, we calculate the weight depending on the temporal distance as follows: )(] 2000 )( exp[)( in in tt tt tt g in ≥ −− =α (2) Equation (2) indicates that at a given time t n (measured in milliseconds), the closer a gesture (at t i ) is to the time t n, the higher impact this gesture has on the salience distribution (Chai et al., 2004b).
P04-1001
