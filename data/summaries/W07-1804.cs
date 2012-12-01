An approach taken in both dialogue systems and dictation applications is to write a grammar for the particular domain and generate an artificial corpus from the grammar to be used as training corpus for SLMs (Galescu et al., 1998; Bangalore and Johnston, 2003; Jonson, 2006).
E06-1008
Apart from evaluating a different domain in a more extensive way to see if the tendency we found in (Jonson, 2006) is consisting over domains, we have driven the methodology a bit further to be able to generate context-specific SLMs that favour certain parts of the grammar, in our case certain dialogue moves.
E06-1008
However, as has been shown in (Bangalore and Johnston, 2003; Jonson, 2006) these grammar-based statistical models seem to have a much more robust behaviour than their corresponding grammars which leaves us with a much better starting point in the first development stage in a dialogue system.
E06-1008
2 Grammar-based SLMs In (Jonson, 2006) we described how we could generate an SLM from an interpretation grammar written in GF for an MP3 player application and get a much more robust behaviour than by using the original grammar for ASR.
E06-1008
In this paper, we will show how we can use the same methodology as in (Jonson, 2006) to create context-specific SLMs from grammars based on dialogue moves that match these criteria.
E06-1008
Rayner, et al.2000. Evaluation.
C00-2097
Adding real speech corpora In (Jonson, 2006) we saw that the use of real corpora in interpolation with our artificial corpus was only valuable as long as the real corpora approximated the language of use.
E06-1008
Table 8: DMSLMs on general test set Model WER SER Answer DMSLM 34.7% 55.6% Ask DMSLM 28.2% 46.2% Request DMSLM 26.5% 43.2% YN DMSLM 29.8% 44.0% 5 Concluding remarks Our experimental results show that grammar-based SLMs give an important reduction in both WER and DMER in accordance with the results in (Jonson, 2006).
E06-1008
SLMs from GF Grammars Jonson (2006) has shown that in addition to generating grammar-based language models, GF can be used to build statistical language models (SLMs).
E06-1008
In Rayner et al.(Rayner et al., 2000).
C00-2097
Forslund, David Hjelm, Rebecca Jonson, Staffan Larsson, Peter Ljunglof, Pilar Manchon,David Milward, Guillermo Perez, and Mikael Sandin.2006.
E06-1008
The grammatical coverage is similar to the Core Language Engine (Rayner et al., 2000).
C00-2097
A common approach is to write a grammar for the domain either as a speech recognition grammar (SRG) or as an interpretation grammar which can be compiled into a speech recognition grammar (SRG) using some grammar development platform such as Gemini, Regulus or GF (Rayner et al., 2000; Rayner et al., 2006; Ranta, 2004).
C00-2097
