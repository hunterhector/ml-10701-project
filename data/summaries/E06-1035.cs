Text segmentation, i.e., determining the points at which the topic changes in a stream of text, plays an important role in applications such as topic detection and tracking, summarization, automatic genre detection and information retrieval and extraction (Pevzner and Hearst, 2002).
J02-1002
Compared to the task of segmenting expository texts reported in Hearst (1997) with a 39.1% chance of each paragraph end being a target topic boundary, the chance of each speaker turn being a top-level or sub-topic boundary in our ICSI corpus is just 2.2% and 0.69%.
J97-1003
2: Statistically learned cue phrases In prior work, Galley et al.(2003) empirically identified cue phrases that are indicators of segment boundaries, and then eliminated all cues that had not previously been identified as cue phrases in the literature.
P03-1071
We first used features extracted with the optimal window size reported to perform best in Galley et al.(2003) for segmenting meeting transcripts into major topical units.
P03-1071
M.Hearst. 1997.
J97-1003
These include algorithms based on lexical cohesion (Galley et al., 2003; Stokes et al., 2004), as well as models using annotated features (e.g., cue phrases, part-of-speech tags, coreference relations) that have been determined to correlate with segment boundaries (Gavalda et al., 1997; Beeferman et al., 1999).
A97-1003 P03-1071
Galley et al.(2003) report an error rate (Pk) of 0.319 for the task of predicting major topic segments in meetings.1 Although recordings of multiparty dialogue lack the distinct segmentation cues commonly found in text (e.g., headings, paragraph breaks, andothertypographic cues) ornewsstory segmentation (e.g., the distinction between anchor and interview segments), they contain conversationbased features that may be of use for automatic segmentation.
P03-1071
cohesion-based model In this study, we use Galley et al.’s (2003) LCSeg algorithm, a variant of TextTiling (Hearst, 1997).
J97-1003 P03-1071
These include silence, overlap rate, speaker activity change (Galley et al., 2003), and cross-speaker linking information, such as adjacency pairs (Zechner and Waibel, 2000).
C00-2140 P03-1071
For segmenting spontaneous multiparty dialogue into major topic segments, Galley et al.(2003) have shownthat amodel integrating lexical and conversation-based features outperforms one based on solely lexical cohesion information.
P03-1071
WindowDiff (Wd) (Pevzner and Hearst, 2002) calculates the error rate by moving a sliding window across the meeting transcript counting the number of times the hypothesized and reference segment boundaries are different.
J02-1002
This is not surprising, because these were the features that Galley et al.(2003) found to be most effective for predicting top-level segment boundaries in their combined model.
P03-1071
To compute a baseline, we follow Kan (2003) and Hearst (1997) in using Monte Carlo simulated segments.
J97-1003
