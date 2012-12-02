However, the difference between their performance and that of the Maximum Entropy approach of Chieu and Ng (2003) is not significant.
W03-0423
A majority vote of five systems (Chieu and Ng, 2003; Florian et al., 2003; Klein et al., 2003; McCallum and Li, 2003; Whitelaw and Patrick, 2003) performed best on the English development data.
W03-0423 W03-0425 W03-0428 W03-0430 W03-0432
The inclusion of extra named entity recognition systems seems to have worked well (Florian et al., 2003).
W03-0425
Florian et al.(2003) tested different methods for combining the results of four systems and found that robust risk minimization worked best.
W03-0425
Transformation-based learning (Florian et al., 2003), Support Vector Machines (Mayfield et al., 2003) and Conditional Random Fields (McCallum and Li, 2003) were applied by one system each.
W03-0425 W03-0429 W03-0430
The best performance for both languages has been obtained by a combined learning system that used Maximum Entropy Models, transformation-based learning, Hidden Markov Models as well as robust risk minimization (Florian et al., 2003).
W03-0425
Here there is no significant difference between them and the systems of Klein et al.(2003) and Zhang and Johnson (2003).
W03-0428 W03-0434
This tagging scheme is the IOB scheme originally put forward by Ramshaw and Marcus (1995).
W95-0107
Four groups examined the usability of unannotated data, either for extracting training instances (Bender et al., 2003; Hendrickx and Van den Bosch, 2003) or obtaining extra named entities for gazetteers (De Meulder and Daelemans, 2003; McCallum and Li, 2003).
W03-0420 W03-0427 W03-0430 W03-0435
Wu et al.(2003) applied both stacking and voting to three learners.
W03-0433
Othographic information, affixes, gazetteers and chunk information were also incorporated in most systems although one group reports that the available chunking information did not help (Wu et al., 2003) Other features were used less frequently.
W03-0433
The performance of the system of Chieu et al.(2003) was not significantly different from the best performance for English and the method of Klein et al.(2003) and the approach of Zhang and Johnson (2003) were not significantly worse than the best result for German.
W03-0423 W03-0428 W03-0434
Munro et al.(2003) employed both voting and bagging for combining classifiers.
W03-0431
Klein et al.(2003) also applied the related Conditional Markov Models for combining classifiers.
W03-0428
All participants used lexical features (words) except for Whitelaw and Patrick (2003) who implemented a character-based method.
W03-0432
One participating team has used externally trained named entity recognition systems for English as a part in a combined system (Florian et al., 2003).
W03-0425
Florian et al.(2003) employed the same technique in a combination of learners.
W03-0425
Another combination of five systems (Carreras et al., 2003b; Mayfield et al., 2003; McCallum and Li, 2003; Munro et al., 2003; Zhang and Johnson, 2003) obtained the best result for the German development data.
W03-0421 W03-0422 W03-0429 W03-0430 W03-0431 W03-0434
Hidden Markov Models were employed by four of the systems that took part in the shared task (Florian et al., 2003; Klein et al., 2003; Mayfield et al., 2003; Whitelaw and Patrick, 2003).
W03-0425 W03-0428 W03-0429 W03-0432
Florian et al.(2003) have also obtained the highest Fβ=1 rate for the German data.
W03-0425
Zhang and Johnson (2003) used robust risk minimization, which is a Winnow technique.
W03-0434
Three systems used Maximum Entropy Models in isolation (Bender et al., 2003; Chieu and Ng, 2003; Curran and Clark, 2003).
W03-0420 W03-0423 W03-0424
Two teams used AdaBoost.MH (Carreras et al., 2003b; Wu et al., 2003) and two other groups employed memory-based learning (De Meulder and Daelemans, 2003; Hendrickx and Van den Bosch, 2003).
W03-0421 W03-0422 W03-0427 W03-0433 W03-0435
Mayfield et al.(2003) stacked two learners and obtained better performance.
W03-0429
The performance in this task is measured with Fβ=1 rate: Fβ = (β 2 + 1)∗ precision ∗ recall (β2 ∗ precision + recall) (1) lex pos aff pre ort gaz chu pat cas tri bag quo doc Florian + + + + + + + + Chieu + + + + + + + + + Klein + + + + Zhang + + + + + + + + Carreras (a) + + + + + + + + + + Curran + + + + + + + + Mayfield + + + + + + + + Carreras (b) + + + + + + McCallum + + + + Bender + + + + + + Munro + + + + + + + Wu + + + + + + Whitelaw + + + Hendrickx + + + + + + + De Meulder + + + + + + + Hammerton + + + + Table 3: Main features used by the the sixteen systems that participated in the CoNLL-2003 shared task sorted by performance on the English test data.
W03-0426
Most of the systems employed part-of-speech tags and two of them have recomputed the English tags with better taggers (Hendrickx and Van den Bosch, 2003; Wu et al., 2003).
W03-0427 W03-0433
Klein et al.(2003) employed a stacked learning system which contains Hidden Markov Models, Maximum Entropy Models and Conditional Markov Models.
W03-0428
The shared task of CoNLL-2002 dealt with named entity recognition for Spanish and Dutch (Tjong Kim Sang, 2002).
W02-2024
Voted perceptrons were applied to the shared task data by Carreras et al.(2003a) and Hammerton used a recurrent neural network (Long Short-Term Memory) for finding named entities.
W03-0421 W03-0422
Two more systems used them in combination with other techniques (Florian et al., 2003; Klein et al., 2003).
W03-0425 W03-0428
For English, the combined classifier of Florian et al.(2003) achieved the highest overall Fβ=1 rate.
W03-0425
With the exception of the result of Zhang and Johnson (2003), there is not much difference in the German results between the gains obtained by using gazetteers and those obtained by using unannotated data.
W03-0434
