In this setting, the features might include questions such as: • Does the phrase COMING UP appear in the last utterance of the decoded speech? • Is there a sharp change in the video stream in the last 20 frames? • Does the language model degrade in performance in the next two utterances? • Is there a "match" between the spectrum of the current image and an image near the last segment boundary? • Are there blank video frames nearby? • Is there a sharp change in the audio stream in the next utterance? 36 The idea of using features is a natural one, and indeed other recent work on segmentation, such as (Litman and Passonneau, 1995), adopts this approach.
P95-1015
Feature-Based Approach Our attack on the segmentation problem is based on a statistical framework that we call feature induction for random fields and exponential models (Berger, Della Pietra, and Della Pietra, 1996; Della Pietra, Della Pietra, and Lafferty, 1997).
J96-1002
Another approach, using maximum entropy methods, introduces a parameter for trigger pairs of mutually informative words, so that the occurrence of certain words in recent context boosts the probability of the words that they trigger (Lau, Rosenfeld, and Roukos, 1993).
H93-1021
cohesion (Kozima, 1993) employs a "lexical cohesion profile" to keep track of the semantic cohesiveness of words in a text within a fixed-length window.
P93-1041
tiling The Te~ctTiling algorithm, introduced by Hearst (Hearst, 1994), segments expository texts into multiple paragraphs of coherent discourse units.
P94-1002
As described in (Beeferman, Berger, and Lafferty, 1997), for each (s,t) trigger pair there corresponds a real-valued parameter A; the probability of t is boosted by a factor of e x for W words following the occurrence of si.
P97-1048
One means of injecting long-range awareness into a language model is by retaining a cache of the most recently seen n-grams which is smoothed together (typically by linear interpolation) with the static model; see for example (Jelinek et al., 1991; Kuhn and de Mori, 1990).
H91-1057
trees (Litman and Passonneau, 1995) presents an algorithm that uses decision trees to combine multiple linguistic features extracted from corpora of spoken text, including prosodic and lexical cues.
P95-1015
Hearst, M.A. 1994.
P94-1002
The method we use here, described in (Beeferman, Berger, and Lafferty, 1997), employs a static trigram model as a "prior," or default distribution, and adds certain features to a family of conditional exponential models to capture some of the nonstationary features of text.
P97-1048
